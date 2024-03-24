using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Freyja
{
    public partial class DecorTextBox : UserControl
    {
        
        private Color borderColor = Color.MediumBlue;
        private int borderSize = 2;
        private bool underLineStyle = false;

       

        public DecorTextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderLineStyle
        {
            get
            {
                return underLineStyle;
            }

            set
            {
                underLineStyle = value;
                this.Invalidate();
            }
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            ////Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underLineStyle) //Line Style
                {
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else //Normal Style
                {
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            SetWatermark(watermarkText);
        }

        //Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private string watermarkText;
        public string WatermarkText
        {
            get { return watermarkText; }
            set
            {
                watermarkText = value;
                SetWatermark(watermarkText);
            }
        }

        private void SetWatermark(string watermarkText)
        {
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }


    }
}
