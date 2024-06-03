using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Freyja
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public TcpClient connectToServer(Diffie_Hellman dh)
        {
            
            output.Text = "Подключение клиента к серверу...";
            try
            {
                TcpClient client = new TcpClient("217.71.129.139", 4253);
                return client;
            }
            catch (Exception ex)
            {
                this.Show();
                status.Text = "Ошибка!";
                output.Text = "Error: " + ex.Message;

                return null;
            }
        }


        public void sendMessage(string message, TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            string encodedMessage = Convert.ToBase64String(Encoding.UTF8.GetBytes(message));
            writer.WriteLine(encodedMessage);
            writer.Flush();
        }

        public string catchMessage(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            string encodedResponse = reader.ReadLine();
            if(encodedResponse != null)
            {
                string message = Encoding.UTF8.GetString(Convert.FromBase64String(encodedResponse));
                return message;
            }

            this.Show();
            status.Text = "Ошибка!";
            output.Text = "";

            return "Error_connect";
            
        }

        public string workServer(TcpClient client, string msg)
        {
            sendMessage(msg, client);
            return catchMessage(client);
        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
