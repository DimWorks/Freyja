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
        private string hashFile = "NULL";
        private MakeHash mh = new MakeHash();

        public Form1()
        {
            InitializeComponent();

            picture.AllowDrop = true;
            picture.DragEnter += picture_DragEnter;
            picture.DragDrop += picture_DragDrop;

            this.KeyPreview = true; // Говорим, что следим за нажатием клавиши в данной форме
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Control_KeyDown);

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

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

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
            if(mh.hashFile == null)
            {
                MessageBox.Show("Сначала выберите файл");
            }
            else
            {
                MessageBox.Show(mh.hashFile);
            }
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
                openFile.Filter = "Все файлы|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        mh.Show();
                        mh.getHashFileAsync(openFile.FileName);
                        hashFile = mh.hashFile;
                        mh.Close();

                        register.BackColor = Color.LightSeaGreen;
                        register.ForeColor = Color.White;
                        register.BorderSize = 0;

                        check.BackColor = Color.LightSeaGreen;
                        check.ForeColor = Color.White;
                        check.BorderSize = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка доступа к файлу");
                    }
                }
            }

        }

        private void decorButton2_Click(object sender, EventArgs e)
        {
            if (password.Password)
            {
                password.Password = false;
            }
            else
            {
                password.Password = true;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            authentication.Visible = false;
            Client client = new Client();
            client.connectToServer("Test");
            client.Show();
            //MessageBox.Show("login: " + login.Text + "\npass: " + password.Text);
        }
    }
}
