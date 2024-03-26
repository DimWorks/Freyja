using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Freyja
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public void connectToServer(string msg)
        {
            output.Text = "Подключение клиента к серверу...";
            try
            {
                TcpClient client = new TcpClient("217.71.129.139", 4253); // Укажите IP адрес и порт сервера

                if (client.Connected)
                {
                    status.Text = "Успешно";
                    output.Text = "Клиент подключён к серверу.";

                    sendMessage(msg, client);
                }
            }
            catch (Exception ex)
            {
                status.WatermarkText = "Ошибка!";
                output.Text = "Error: " + ex.Message;
            }
        }

        private void sendMessage(string message, TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        //private void SendMessageFromSocket(int port, string message)
        //{
        //    // Буфер для входящих данных
        //    byte[] bytes = new byte[1024];

        //    // Соединяемся с удаленным устройством

        //    output.Text = "Подключение клиента к серверу...";

        //    // Устанавливаем удаленную точку для сокета
        //    IPHostEntry ipHost = Dns.GetHostEntry("localhost");
        //    IPAddress ipAddr = ipHost.AddressList[0];
        //    IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

        //    Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        //    // Соединяем сокет с удаленной точкой
        //    sender.Connect(ipEndPoint);

        //    Console.Write("Введите сообщение: ");

        //    Console.WriteLine("Сокет соединяется с {0} ", sender.RemoteEndPoint.ToString());
        //    byte[] msg = Encoding.UTF8.GetBytes(message);

        //    // Отправляем данные через сокет
        //    int bytesSent = sender.Send(msg);

        //    // Получаем ответ от сервера
        //    int bytesRec = sender.Receive(bytes);

        //    Console.WriteLine("\nОтвет от сервера: {0}\n\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

        //    // Используем рекурсию для неоднократного вызова SendMessageFromSocket()
        //    if (message.IndexOf("<TheEnd>") == -1)
        //        SendMessageFromSocket(port, message);

        //    // Освобождаем сокет
        //    sender.Shutdown(SocketShutdown.Both);
        //    sender.Close();
        //}
    }
}
