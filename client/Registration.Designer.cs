
namespace Freyja
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.decorTextBox1 = new Freyja.DecorTextBox();
            this.okay = new Freyja.DecorButton();
            this.canel = new Freyja.DecorButton();
            this.label1 = new System.Windows.Forms.Label();
            this.login_ = new Freyja.DecorTextBox();
            this.name_ = new Freyja.DecorTextBox();
            this.surname_ = new Freyja.DecorTextBox();
            this.password_ = new Freyja.DecorTextBox();
            this.pass_repeat = new Freyja.DecorTextBox();
            this.SuspendLayout();
            // 
            // decorTextBox1
            // 
            this.decorTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.decorTextBox1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.decorTextBox1.BorderSize = 2;
            this.decorTextBox1.Enabled = false;
            this.decorTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decorTextBox1.Location = new System.Drawing.Point(15, 15);
            this.decorTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.decorTextBox1.MaxLength = 20;
            this.decorTextBox1.Name = "decorTextBox1";
            this.decorTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.decorTextBox1.Password = false;
            this.decorTextBox1.ReadOnly = true;
            this.decorTextBox1.Size = new System.Drawing.Size(325, 39);
            this.decorTextBox1.TabIndex = 0;
            this.decorTextBox1.UnderLineStyle = true;
            this.decorTextBox1.WatermarkText = "";
            // 
            // okay
            // 
            this.okay.BackColor = System.Drawing.SystemColors.Menu;
            this.okay.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.okay.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.okay.BorderRadius = 20;
            this.okay.BorderSize = 2;
            this.okay.FlatAppearance.BorderSize = 0;
            this.okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okay.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okay.ForeColor = System.Drawing.Color.Black;
            this.okay.Location = new System.Drawing.Point(12, 398);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(150, 40);
            this.okay.TabIndex = 1;
            this.okay.Text = "OK";
            this.okay.TextColor = System.Drawing.Color.Black;
            this.okay.UseVisualStyleBackColor = false;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // canel
            // 
            this.canel.BackColor = System.Drawing.SystemColors.Menu;
            this.canel.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.canel.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.canel.BorderRadius = 20;
            this.canel.BorderSize = 2;
            this.canel.FlatAppearance.BorderSize = 0;
            this.canel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canel.ForeColor = System.Drawing.Color.Black;
            this.canel.Location = new System.Drawing.Point(188, 398);
            this.canel.Name = "canel";
            this.canel.Size = new System.Drawing.Size(150, 40);
            this.canel.TabIndex = 2;
            this.canel.Text = "Отмена";
            this.canel.TextColor = System.Drawing.Color.Black;
            this.canel.UseVisualStyleBackColor = false;
            this.canel.Click += new System.EventHandler(this.canel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Регистрация в системе";
            // 
            // login_
            // 
            this.login_.BackColor = System.Drawing.SystemColors.Menu;
            this.login_.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.login_.BorderSize = 2;
            this.login_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_.Location = new System.Drawing.Point(13, 75);
            this.login_.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.login_.MaxLength = 20;
            this.login_.Name = "login_";
            this.login_.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.login_.Password = false;
            this.login_.ReadOnly = false;
            this.login_.Size = new System.Drawing.Size(325, 37);
            this.login_.TabIndex = 4;
            this.login_.UnderLineStyle = true;
            this.login_.WatermarkText = "Введите логин";
            // 
            // name_
            // 
            this.name_.BackColor = System.Drawing.SystemColors.Menu;
            this.name_.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.name_.BorderSize = 2;
            this.name_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_.Location = new System.Drawing.Point(13, 137);
            this.name_.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.name_.MaxLength = 15;
            this.name_.Name = "name_";
            this.name_.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.name_.Password = false;
            this.name_.ReadOnly = false;
            this.name_.Size = new System.Drawing.Size(325, 37);
            this.name_.TabIndex = 5;
            this.name_.UnderLineStyle = true;
            this.name_.WatermarkText = "Введите имя";
            // 
            // surname_
            // 
            this.surname_.BackColor = System.Drawing.SystemColors.Menu;
            this.surname_.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.surname_.BorderSize = 2;
            this.surname_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_.Location = new System.Drawing.Point(13, 199);
            this.surname_.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.surname_.MaxLength = 20;
            this.surname_.Name = "surname_";
            this.surname_.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.surname_.Password = false;
            this.surname_.ReadOnly = false;
            this.surname_.Size = new System.Drawing.Size(325, 37);
            this.surname_.TabIndex = 6;
            this.surname_.UnderLineStyle = true;
            this.surname_.WatermarkText = "Введите фамилию";
            // 
            // password_
            // 
            this.password_.BackColor = System.Drawing.SystemColors.Menu;
            this.password_.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.password_.BorderSize = 2;
            this.password_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_.Location = new System.Drawing.Point(13, 261);
            this.password_.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.password_.MaxLength = 15;
            this.password_.Name = "password_";
            this.password_.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.password_.Password = true;
            this.password_.ReadOnly = false;
            this.password_.Size = new System.Drawing.Size(325, 37);
            this.password_.TabIndex = 7;
            this.password_.UnderLineStyle = true;
            this.password_.WatermarkText = "Введите пароль";
            // 
            // pass_repeat
            // 
            this.pass_repeat.BackColor = System.Drawing.SystemColors.Menu;
            this.pass_repeat.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.pass_repeat.BorderSize = 2;
            this.pass_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_repeat.Location = new System.Drawing.Point(13, 323);
            this.pass_repeat.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.pass_repeat.MaxLength = 15;
            this.pass_repeat.Name = "pass_repeat";
            this.pass_repeat.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pass_repeat.Password = true;
            this.pass_repeat.ReadOnly = false;
            this.pass_repeat.Size = new System.Drawing.Size(325, 37);
            this.pass_repeat.TabIndex = 8;
            this.pass_repeat.UnderLineStyle = true;
            this.pass_repeat.WatermarkText = "Повторите пароль";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.pass_repeat);
            this.Controls.Add(this.password_);
            this.Controls.Add(this.surname_);
            this.Controls.Add(this.name_);
            this.Controls.Add(this.login_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canel);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.decorTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DecorTextBox decorTextBox1;
        private DecorButton okay;
        private DecorButton canel;
        private System.Windows.Forms.Label label1;
        private DecorTextBox login_;
        private DecorTextBox name_;
        private DecorTextBox surname_;
        private DecorTextBox password_;
        private DecorTextBox pass_repeat;
    }
}