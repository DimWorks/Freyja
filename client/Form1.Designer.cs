
namespace Freyja
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.decorButton2 = new Freyja.DecorButton();
            this.addFile = new Freyja.DecorButton();
            this.decorButton3 = new Freyja.DecorButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picture.ErrorImage")));
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture.InitialImage")));
            this.picture.Location = new System.Drawing.Point(-3, -45);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(790, 464);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            this.picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // decorButton2
            // 
            this.decorButton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.decorButton2.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.decorButton2.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.decorButton2.BorderRadius = 20;
            this.decorButton2.BorderSize = 2;
            this.decorButton2.FlatAppearance.BorderSize = 0;
            this.decorButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decorButton2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decorButton2.ForeColor = System.Drawing.Color.White;
            this.decorButton2.Location = new System.Drawing.Point(500, 320);
            this.decorButton2.Name = "decorButton2";
            this.decorButton2.Size = new System.Drawing.Size(183, 59);
            this.decorButton2.TabIndex = 9;
            this.decorButton2.Text = "Проверить файл";
            this.decorButton2.TextColor = System.Drawing.Color.White;
            this.decorButton2.UseVisualStyleBackColor = false;
            // 
            // addFile
            // 
            this.addFile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addFile.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.addFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addFile.BorderRadius = 20;
            this.addFile.BorderSize = 0;
            this.addFile.FlatAppearance.BorderSize = 0;
            this.addFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFile.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFile.ForeColor = System.Drawing.Color.White;
            this.addFile.Location = new System.Drawing.Point(320, 275);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(150, 50);
            this.addFile.TabIndex = 8;
            this.addFile.Text = "Добавить файл";
            this.addFile.TextColor = System.Drawing.Color.White;
            this.addFile.UseVisualStyleBackColor = false;
            // 
            // decorButton3
            // 
            this.decorButton3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.decorButton3.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.decorButton3.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.decorButton3.BorderRadius = 20;
            this.decorButton3.BorderSize = 2;
            this.decorButton3.FlatAppearance.BorderSize = 0;
            this.decorButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decorButton3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decorButton3.ForeColor = System.Drawing.Color.White;
            this.decorButton3.Location = new System.Drawing.Point(100, 320);
            this.decorButton3.Name = "decorButton3";
            this.decorButton3.Size = new System.Drawing.Size(180, 60);
            this.decorButton3.TabIndex = 7;
            this.decorButton3.Text = "Загрузить файл";
            this.decorButton3.TextColor = System.Drawing.Color.White;
            this.decorButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.decorButton2);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.decorButton3);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фрейя";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox picture;
        private DecorButton decorButton3;
        private DecorButton addFile;
        private DecorButton decorButton2;
    }
}

