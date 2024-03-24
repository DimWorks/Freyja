using System;
using System.IO;
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

        //public string getHashFile(string path)
        //{
        //    return GetHashFileAsync(path).Result;
        //}

        //private Task<string> GetHashFileAsync(string path)
        //{
        //    var tcs = new TaskCompletionSource<string>();

        //    BackgroundWorker worker = new BackgroundWorker();
        //    worker.WorkerReportsProgress = true; // Разрешаем отчет о прогрессе

        //    worker.DoWork += (sender, e) =>
        //    {
        //        using (var stream = File.OpenRead(path))
        //        {
        //            long totalBytes = stream.Length;
        //            long processedBytes = 0;
        //            const int bufferSize = 4096;
        //            byte[] buffer = new byte[bufferSize];

        //            using (var sha256 = SHA256.Create())
        //            {
        //                int bytesRead;
        //                do
        //                {
        //                    bytesRead = stream.Read(buffer, 0, bufferSize);
        //                    processedBytes += bytesRead;

        //                    sha256.TransformBlock(buffer, 0, bytesRead, buffer, 0);

        //                    int progressPercentage = (int)((double)processedBytes / totalBytes * 100);
        //                    worker.ReportProgress(progressPercentage); // Сообщаем о прогрессе выполнения

        //                } while (bytesRead > 0);

        //                sha256.TransformFinalBlock(buffer, 0, 0);
        //                byte[] hash = sha256.Hash;

        //                string hashString = BitConverter.ToString(hash).Replace("-", String.Empty);

        //                e.Result = hashString; // Сохраняем результат хэширования
        //            }
        //        }
        //    };

        //    worker.ProgressChanged += (sender, e) =>
        //    {
        //        // Обновляем элементы пользовательского интерфейса с информацией о прогрессе
        //        progressBar.Value = e.ProgressPercentage;
        //    };

        //    worker.RunWorkerCompleted += (sender, e) =>
        //    {
        //        if (e.Error != null)
        //        {
        //            MessageBox.Show("Error: " + e.Error.Message);
        //            tcs.SetResult(null);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Yes!");
        //            tcs.SetResult(e.Result.ToString());
        //        }
        //    };

        //    worker.RunWorkerAsync(); // Запускаем фоновый процесс

        //    return tcs.Task;
        //}

        public string hashFile { get; set; }

        public void getHashFileAsync(string path)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true; // Разрешаем отчет о прогрессе

            worker.DoWork += (sender, e) =>
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
                    hashFile = e.Result.ToString();
                    this.Close();
                    //MessageBox.Show("Hash: " + e.Result.ToString()); // Выводим хэш в сообщении                    
                }
            };

            worker.RunWorkerAsync(); // Запускаем фоновый процесс
        }
    }
}
