
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.check = new Freyja.DecorButton();
            this.addFile = new Freyja.DecorButton();
            this.register = new Freyja.DecorButton();
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
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.Menu;
            this.check.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.check.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.check.BorderRadius = 20;
            this.check.BorderSize = 2;
            this.check.FlatAppearance.BorderSize = 0;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.Black;
            this.check.Location = new System.Drawing.Point(500, 320);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(185, 60);
            this.check.TabIndex = 9;
            this.check.Text = "Проверить";
            this.check.TextColor = System.Drawing.Color.Black;
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
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
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.Menu;
            this.register.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.register.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.register.BorderRadius = 20;
            this.register.BorderSize = 2;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(100, 320);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(185, 60);
            this.register.TabIndex = 7;
            this.register.Text = "Зарегистрировать";
            this.register.TextColor = System.Drawing.Color.Black;
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.check);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.register);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фрейя";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picture;
        private DecorButton register;
        private DecorButton addFile;
        private DecorButton check;
    }
}

