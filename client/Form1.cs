using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Freyja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            picture.AllowDrop = true;
            picture.DragEnter += picture_DragEnter;
            picture.DragDrop += picture_DragDrop;
        }

        private void picture_DragDrop(object sender, DragEventArgs e)
        {
            register.BackColor = Color.LightSeaGreen;
            register.ForeColor = Color.White;
            register.BorderSize = 0;

            check.BackColor = Color.LightSeaGreen;
            check.ForeColor = Color.White;
            check.BorderSize = 0;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            MakeHash mh = new MakeHash();
            mh.Show();
            mh.getHashFileAsync(files[0]);
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {

        }

        private void addFile_Click(object sender, EventArgs e)
        {
            string pathFile = "";
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Выберите файл, который зарегестрировать";
                openFile.Filter = "Все файлы| *.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MakeHash mh = new MakeHash();
                        mh.Show();
                        mh.getHashFileAsync(openFile.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка доступа к файлу");
                    }
                }
            }

        }
        
    }
}
