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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
            {
                MessageBox.Show(file);
            }
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}
