package main

import (
	"bufio"
	"database/sql"
	"encoding/base64"
	"fmt"
	"io"
	"log"
	"net"
	"os"
	"strconv"
	"strings"
	"time"

	_ "github.com/lib/pq"
)

const (
	address = "172.17.6.80:8080"
	connStr = "user=freyja_admin password=brisingamen_22 dbname=freyja_db sslmode=disable"
)

func main() {
	// Открытие файла для логов
	logFile, err := os.OpenFile("logs.log", os.O_APPEND|os.O_CREATE|os.O_WRONLY, 0666)
	if err != nil 
	{
		log.Fatal(err)
	}
	defer logFile.Close()

	// Установка вывода логов в файл и в консоль
	multiWriter := io.MultiWriter(os.Stdout, logFile)
	log.SetOutput(multiWriter)

	db, err := sql.Open("postgres", connStr)
	if err != nil 
	{
		log.Fatal(err)
	}
	defer db.Close()

	createTables(db)

	listener, err := net.Listen("tcp", address)
	if err != nil 
	{
		log.Fatal(err)
	}
	defer listener.Close()
	fmt.Printf("Server is listening on %s\n", address)

	for 
	{
		conn, err := listener.Accept()
		if err != nil 
		{
			log.Println(err)
			continue
		}
		go handleConnection(conn, db)
	}
}

func handleConnection(conn net.Conn, db *sql.DB) 
{
	defer conn.Close()
	clientAddr := conn.RemoteAddr().String()
	log.Printf("Client connected: %s", clientAddr)

	scanner := bufio.NewScanner(conn)
	for scanner.Scan() 
	{
		encodedRequest := scanner.Text()
		requestBytes, err := base64.StdEncoding.DecodeString(encodedRequest)
		if err != nil 
		{
			log.Println("Failed to decode request:", err)
			conn.Write([]byte("Error\n"))
			continue
		}
		request := string(requestBytes)

		log.Printf("Received from %s: %s", clientAddr, request)

		response := processRequest(request, db)
		encodedResponse := base64.StdEncoding.EncodeToString([]byte(response))
		conn.Write([]byte(encodedResponse + "\n"))
	}
}

func processRequest(request string, db *sql.DB) string 
{
	parts := strings.Fields(request)
	if len(parts) == 0 
	{
		return "Invalid request"
	}
	switch parts[0] 
	{
	case "user":
		if len(parts) != 3 
		{
			return "Invalid user request format"
		}
		return handleUser(parts[1], parts[2], db)
	case "add":
		if len(parts) != 5 
		{
			return "Invalid add request format"
		}
		return handleAdd(parts[1], parts[2], parts[3], parts[4], db)
	case "check":
		if len(parts) != 3 
		{
			return "Invalid check request format"
		}
		return handleCheck(parts[1], parts[2], db)
	case "register":
		if len(parts) != 5 
		{
			return "Invalid register request format"
		}
		return handleRegister(parts[1], parts[2], parts[3], parts[4], db)
	default:
		return "Unknown request"
	}
}

func handleUser(login, password string, db *sql.DB) string 
{
	var surname, name, passHash string
	err := db.QueryRow("SELECT surname, name, pass_hash FROM users_tab WHERE login = $1", login).Scan(&surname, &name, &passHash)
	if err != nil 
	{
		if err == sql.ErrNoRows 
		{
			return "Not_found"
		}
		log.Println(err)
		return "Error"
	}

	if passHash != password 
	{
		return "pass_incor"
	}
	return fmt.Sprintf("%s#%s", surname, name)
}

func handleAdd(hashFile, typeFile, days, user string, db *sql.DB) string 
{
	var userID int
	err := db.QueryRow("SELECT ID FROM users_tab WHERE login = $1", user).Scan(&userID)
	if err != nil 
	{
		if err == sql.ErrNoRows 
		{
			return "User_not_found"
		}
		log.Println(err)
		return "Error"
	}

	daysInt, err := strconv.Atoi(days)
	if err != nil 
	{
		log.Println(err)
		return "Invalid_days_format"
	}
	finishDay := time.Now().AddDate(0, 0, daysInt).Format("2006-01-02")

	_, err = db.Exec("INSERT INTO file (f_hash, type, id_user, finish_day) VALUES ($1, $2, $3, $4)", hashFile, typeFile, userID, finishDay)
	if err != nil 
	{
		log.Println(err)
		return "Error"
	}

	return "File_registered"
}

func handleCheck(hashFile, typeFile string, db *sql.DB) string 
{
	var userID int
	var finishDay, startDay string
	err := db.QueryRow("SELECT id_user, finish_day, start_day FROM file WHERE f_hash = $1 AND type = $2", hashFile, typeFile).Scan(&userID, &finishDay, &startDay)
	if err != nil 
	{
		if err == sql.ErrNoRows 
		{
			return "Not_found"
		}
		log.Println(err)
		return "Error"
	}

	var surname, name string
	err = db.QueryRow("SELECT surname, name FROM users_tab WHERE ID = $1", userID).Scan(&surname, &name)
	if err != nil 
	{
		if err == sql.ErrNoRows 
		{
			return "Not_found"
		}
		log.Println(err)
		return "Error"
	}

	return fmt.Sprintf("yes#%s#%s#%s#%s#%s", surname, name, startDay, finishDay, typeFile)
}

func handleRegister(login, password, name, surname string, db *sql.DB) string 
{
	_, err := db.Exec("INSERT INTO users_tab (login, pass_hash, name, surname) VALUES ($1, $2, $3, $4)", login, password, name, surname)
	if err != nil 
	{
		if strings.Contains(err.Error(), "duplicate key value violates unique constraint") 
		{
			return "User_exists"
		}
		log.Println(err)
		return "Error"
	}
	return "Registered"
}

func createTables(db *sql.DB) 
{
	queries := []string{
		`CREATE TABLE IF NOT EXISTS users_tab (
			ID SERIAL PRIMARY KEY,
			login VARCHAR(20) UNIQUE,
			pass_hash VARCHAR(64),
			name VARCHAR(15),
			surname VARCHAR(20)
		)`,
		`CREATE TABLE IF NOT EXISTS file (
			ID SERIAL PRIMARY KEY,
			f_hash VARCHAR(64) UNIQUE,
			type VARCHAR(10),
			id_user INTEGER,
			start_day DATE DEFAULT CURRENT_DATE,
			finish_day DATE,
			FOREIGN KEY (id_user) REFERENCES users_tab(ID)
		)`,
	}

	for _, query := range queries 
	{
		_, err := db.Exec(query)
		if err != nil 
		{
			log.Fatal(err)
		}
	}
}
