using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freyja
{
    public partial class Answer : Form
    {
        public Answer()
        {
            InitializeComponent();
        }

        public string Status
        {
            set
            {
                status.Text = value;
                this.Invalidate();
            }
        }

        public string Author
        {
            set 
            { 
                author.Text = value;
                this.Invalidate();
            }
        }

        public string Type_file
        {
            set
            {
                type_file.Text = value;
                this.Invalidate();
            }
        }

        public string Start_day
        {
            set
            {
                start_day.Text = value;
                this.Invalidate();
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
