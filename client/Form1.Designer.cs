
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
            this.label = new System.Windows.Forms.Label();
            this.authentication = new System.Windows.Forms.GroupBox();
            this.enter = new Freyja.DecorButton();
            this.password = new Freyja.DecorTextBox();
            this.login = new Freyja.DecorTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check = new Freyja.DecorButton();
            this.addFile = new Freyja.DecorButton();
            this.register = new Freyja.DecorButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.authentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picture.ErrorImage")));
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture.InitialImage")));
            this.picture.Location = new System.Drawing.Point(-3, -45);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(790, 405);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            this.picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label.Location = new System.Drawing.Point(280, 226);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(233, 46);
            this.label.TabIndex = 10;
            this.label.Text = "Перетащите файл сюда \r\nили нажмите";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authentication
            // 
            this.authentication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.authentication.Controls.Add(this.enter);
            this.authentication.Controls.Add(this.password);
            this.authentication.Controls.Add(this.login);
            this.authentication.Controls.Add(this.pictureBox1);
            this.authentication.Location = new System.Drawing.Point(-3, -9);
            this.authentication.Name = "authentication";
            this.authentication.Size = new System.Drawing.Size(790, 420);
            this.authentication.TabIndex = 11;
            this.authentication.TabStop = false;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.Menu;
            this.enter.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.enter.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.enter.BorderRadius = 20;
            this.enter.BorderSize = 2;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.ForeColor = System.Drawing.Color.Black;
            this.enter.Location = new System.Drawing.Point(294, 357);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(186, 41);
            this.enter.TabIndex = 5;
            this.enter.Text = "Войти";
            this.enter.TextColor = System.Drawing.Color.Black;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Menu;
            this.password.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.password.BorderSize = 2;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(459, 295);
            this.password.Margin = new System.Windows.Forms.Padding(6);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(7);
            this.password.Password = true;
            this.password.Size = new System.Drawing.Size(229, 39);
            this.password.TabIndex = 4;
            this.password.UnderLineStyle = true;
            this.password.WatermarkText = "Введите пароль";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Menu;
            this.login.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.login.BorderSize = 2;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(103, 295);
            this.login.Margin = new System.Windows.Forms.Padding(6);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(7);
            this.login.Password = false;
            this.login.Size = new System.Drawing.Size(229, 39);
            this.login.TabIndex = 3;
            this.login.UnderLineStyle = true;
            this.login.WatermarkText = "Введите логин";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.authentication);
            this.Controls.Add(this.label);
            this.Controls.Add(this.check);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.register);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фрейя";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.authentication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture;
        private DecorButton register;
        private DecorButton addFile;
        private DecorButton check;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox authentication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DecorTextBox password;
        private DecorTextBox login;
        private DecorButton enter;
    }
}

