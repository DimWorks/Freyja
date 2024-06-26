﻿using System;
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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        public string day
        {
            get { return days.SelectedIndex.ToString(); }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if(day != "-1")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Выберите срок действия подписи");
            }
            
        }

        private void decorButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }
    }
}
