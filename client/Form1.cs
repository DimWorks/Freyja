using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;


namespace Freyja
{
    public partial class Form1 : Form
    {
        private MakeHash mh = new MakeHash();
        private Diffie_Hellman dh = new Diffie_Hellman();
        private TcpClient tcpClient = new TcpClient();
        private string type_file;
        private static List<string> data = new List<string>();
        private Client client = new Client();

        public Form1()
        {
            InitializeComponent();

            tcpClient = client.connectToServer(dh);

            picture.AllowDrop = true;
            picture.DragEnter += picture_DragEnter;
            picture.DragDrop += picture_DragDrop;

            // Говорим, что следим за нажатием клавиши в данной форме
            this.KeyPreview = true; 
            this.KeyDown += new KeyEventHandler(Control_KeyDown);

        }

        public static void decapitation(string msg)
        {
            if(msg != "")
            {
                data.Clear();
                var temp = msg.Split('#');
                foreach (var item in temp)
                {
                    data.Add(item);
                }
            }            
        }


        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) enter.PerformClick();
        }


        private void picture_DragDrop(object sender, DragEventArgs e)
        {
            register.BackColor = Color.LightSeaGreen;
            register.ForeColor = Color.White;
            register.BorderSize = 0;

            check.BackColor = Color.LightSeaGreen;
            check.ForeColor = Color.White;
            check.BorderSize = 0;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            mh.Show();
            mh.getHashFileAsync(files[0]);
            FileInfo fi = new FileInfo(files[0]);
            type_file = fi.Extension;

            files = null;
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(mh.hashFile == null)
            {
                MessageBox.Show("Сначала выберите файл");
            }
            else
            {
                
                Confirmation confirm = new Confirmation();
                if(confirm.ShowDialog() == DialogResult.OK)
                {
                    int[] days = new int[] { 1, 3, 7, 14, 30, 90, 180, 365 };

                    client.sendMessage("add " + mh.hashFile + " " + type_file + " " + days[int.Parse(confirm.day)] + " " + login.Text, tcpClient);
                    if(client.catchMessage(tcpClient) == "Error")
                    {
                        MessageBox.Show("Этот файл уже подписан");
                    }
                    else
                    {
                        MessageBox.Show("Файл успешно добавлен");
                    }
                }
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (mh.hashFile == null)
            {
                MessageBox.Show("Сначала выберите файл");
            }
            else
            {
                string tmp = "check " + mh.hashFile + " " + type_file;
                decapitation(client.workServer(tcpClient, tmp));

                if(data[0] == "yes")
                {
                    Answer ans = new Answer();
                    ans.Status = "Подтверждено";
                    ans.Author = data[1] + " " + data[2];
                    ans.Start_day = data[3].Remove(10); 
                    ans.Type_file = data[5];
                    ans.ShowDialog();
                }
                else if (data[0] == "Not_found")
                {
                    Answer ans = new Answer();
                    ans.Status = "Не зарегистрирован в системе";
                    ans.ShowDialog();
                }
                else
                {
                    Answer ans = new Answer();
                    ans.Status = "Ошибка проверки";
                    ans.ShowDialog();
                }
            }
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Выберите файл, который зарегестрировать";
                openFile.Filter = "Все файлы|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        mh.Show();
                        mh.getHashFileAsync(openFile.FileName);

                        register.BackColor = Color.LightSeaGreen;
                        register.ForeColor = Color.White;
                        register.BorderSize = 0;

                        check.BackColor = Color.LightSeaGreen;
                        check.ForeColor = Color.White;
                        check.BorderSize = 0;
                        FileInfo fi = new FileInfo(openFile.FileName);
                        type_file = fi.Extension;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка доступа к файлу");
                    }
                }
            }            
        }


        private void enter_Click(object sender, EventArgs e)
        {            

            if (login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Введите логин или пароль пользователя");
            }
            else if (tcpClient != null)
            {
                decapitation(client.workServer(tcpClient, "user " + login.Text + " " + mh.GetHash(password.Text)));
                if(data.Count != 0)
                {
                    if (data[0] != "pass_incor" && data[0] != "Not_found")
                    {
                        user_name.Text = data[0] + " " + data[1];
                        data.Clear();
                        authentication.Visible = false;
                    }
                    else if (data[0] == "Not_found")
                    {
                        MessageBox.Show("Пользователь не найден");
                    }
                    else
                    {
                        MessageBox.Show("Пароль неверный");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка! Повторите попытку");
                }                
            }            
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration registr = new Registration();
            if (registr.ShowDialog() == DialogResult.OK)
            {
                string pass = mh.GetHash(registr.password);

                string tmp = "register " + registr.login + " " + pass + " " + registr.name + " " + registr.surname;

                tmp = client.workServer(tcpClient, tmp);

                if (tmp == "Registered")
                {
                    MessageBox.Show("Регистрация прошла успешно!");
                }
                else if (tmp == "User_exists")
                {
                    MessageBox.Show("Данный пользователь уже существует");
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации");
                }
            }
        }
    }
}
