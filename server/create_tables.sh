#!/bin/bash

# Параметры подключения к базе данных
DB_USER="freyja_admin"
DB_NAME="freyja_db"


# SQL запросы для создания таблицы
SQL_COMMAND="
CREATE TABLE IF NOT EXISTS users_tab (
  ID serial PRIMARY KEY,
  login char(20),
  pass_hash char(64),
  name char(15),
  surname char
);

CREATE TABLE IF NOT EXISTS file_type (
  ID serial PRIMARY KEY,
  type char(5)
);

CREATE TABLE IF NOT EXISTS file (
  ID serial PRIMARY KEY,
  f_hash char(64),
  id_type int REFERENCES file_type(ID)
);

CREATE TABLE IF NOT EXISTS main_tab (
  ID serial PRIMARY KEY,
  start_day date,
  id_user int REFERENCES users_tab(ID),
  file int REFERENCES file(ID),
  finish_day date
);
"
# Выполнение создание таблиц
psql -U $DB_USER -h localhost -d $DB_NAME -c "$SQL_COMMAND"
