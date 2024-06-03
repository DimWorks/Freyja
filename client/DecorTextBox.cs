using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Freyja
{
    public partial class DecorTextBox : UserControl
    {
        
        private Color borderColor = Color.MediumBlue;
        private int borderSize = 2;
        private bool underLineStyle = false;
        private bool isPassword = false;
        private string text;
        private bool isReadOnly = false;

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

        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }

            set
            {
                textBox1.MaxLength = value;
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

        public bool Password
        {
            get
            {
                return isPassword;
            }

            set
            {
                isPassword = value;
                this.Invalidate();
            }
        }

        public bool ReadOnly
        {
            get
            {
                return isReadOnly;
            }

            set
            {
                isReadOnly = value;
                this.Invalidate();
            }
        }

        public string Text
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                text = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
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

                textBox1.UseSystemPasswordChar = isPassword;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Обрабатываем изменение текста в текстбоксе
            string text = textBox1.Text;

            // Используем регулярное выражение, чтобы проверить, что текст состоит только из букв без пробелов
            Regex regex = new Regex(@"^[a-zA-Zа-яА-Я0-9]*$");
            if (!regex.IsMatch(text))
            {
                // Если текст не соответствует регулярному выражению, обрезаем последний введённый символ
                textBox1.Text = Regex.Replace(text, @"[^a-zA-Zа-яА-Я0-9]", "");

                // Устанавливаем курсор в конец текста
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
    }
}
