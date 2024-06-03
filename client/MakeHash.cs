using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Freyja
{
    public partial class MakeHash : Form
    {
        public MakeHash()
        {
            InitializeComponent();
        }        

        public string hashFile { get; set; }

        public void getHashFileAsync(string path)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true; // Разрешаем отчет о прогрессе

            worker.DoWork += (sender, e) =>
            {
                try
                {
                    using (var stream = File.OpenRead(path))
                    {
                        long totalBytes = stream.Length;
                        long processedBytes = 0;
                        const int bufferSize = 4096;
                        byte[] buffer = new byte[bufferSize];

                        using (var sha256 = SHA256.Create())
                        {
                            int bytesRead;
                            do
                            {
                                bytesRead = stream.Read(buffer, 0, bufferSize);
                                processedBytes += bytesRead;

                                sha256.TransformBlock(buffer, 0, bytesRead, buffer, 0);

                                int progressPercentage = (int)((double)processedBytes / totalBytes * 100);
                                worker.ReportProgress(progressPercentage); // Сообщаем о прогрессе выполнения

                            } while (bytesRead > 0);

                            sha256.TransformFinalBlock(buffer, 0, 0);
                            byte[] hash = sha256.Hash;

                            string hashString = BitConverter.ToString(hash).Replace("-", String.Empty);

                            e.Result = hashString; // Сохраняем результат хэширования
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка доступа к файлу");
                }

            };

            worker.ProgressChanged += (sender, e) =>
            {
                // Обновляем элементы пользовательского интерфейса с информацией о прогрессе
                progressBar.Value = e.ProgressPercentage;
            };

            worker.RunWorkerCompleted += (sender, e) =>
            {
                if (e.Error != null)
                {
                    MessageBox.Show("Error: " + e.Error.Message);
                }
                else
                {
                    if(e.Result != null)
                    {
                        hashFile = e.Result.ToString();
                    }                  

                    this.Hide();                   
                }
            };

            worker.RunWorkerAsync(); // Запускаем фоновый процесс
        }

        public string GetHash(string input)
        {
            var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
