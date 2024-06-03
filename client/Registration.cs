using System;
using System.Windows.Forms;

namespace Freyja
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        public string login
        {
            get { return login_.Text; }
        }

        public string name
        {
            get { return name_.Text; }
        }

        public string surname
        {
            get { return surname_.Text; }
        }

        public string password
        {
            get { return password_.Text; }
        }



        private void okay_Click(object sender, EventArgs e)
        {
            if (login_.Text != "" && name_.Text != "" && surname_.Text != "" && password_.Text != "")
            {
                if(password_.Text == pass_repeat.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
                
            }
            else
            {
                MessageBox.Show("Поля не должны оставаться пустыми!");
            }                
        }

        private void canel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
