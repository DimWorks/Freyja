
namespace Freyja
{
    partial class Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Answer));
            this.fon = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.enter = new Freyja.DecorButton();
            this.line = new Freyja.DecorTextBox();
            this.author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start_day = new System.Windows.Forms.Label();
            this.type_file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fon
            // 
            this.fon.BackColor = System.Drawing.SystemColors.Menu;
            this.fon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fon.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fon.Location = new System.Drawing.Point(15, 15);
            this.fon.Name = "fon";
            this.fon.ReadOnly = true;
            this.fon.Size = new System.Drawing.Size(569, 33);
            this.fon.TabIndex = 3;
            this.fon.TabStop = false;
            this.fon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Menu;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(16, 25);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(568, 23);
            this.status.TabIndex = 7;
            this.status.Text = "-";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.enter.Location = new System.Drawing.Point(205, 207);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(186, 41);
            this.enter.TabIndex = 6;
            this.enter.Text = "ОК";
            this.enter.TextColor = System.Drawing.Color.Black;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.Menu;
            this.line.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.line.BorderSize = 2;
            this.line.Enabled = false;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.line.Location = new System.Drawing.Point(15, 15);
            this.line.Margin = new System.Windows.Forms.Padding(6);
            this.line.MaxLength = 20;
            this.line.Name = "line";
            this.line.Padding = new System.Windows.Forms.Padding(7);
            this.line.Password = false;
            this.line.ReadOnly = true;
            this.line.Size = new System.Drawing.Size(569, 39);
            this.line.TabIndex = 2;
            this.line.TabStop = false;
            this.line.UnderLineStyle = true;
            this.line.WatermarkText = null;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.Location = new System.Drawing.Point(156, 158);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(16, 23);
            this.author.TabIndex = 9;
            this.author.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Автор файла: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата регистрации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип файла: ";
            // 
            // start_day
            // 
            this.start_day.AutoSize = true;
            this.start_day.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_day.Location = new System.Drawing.Point(201, 75);
            this.start_day.Name = "start_day";
            this.start_day.Size = new System.Drawing.Size(16, 23);
            this.start_day.TabIndex = 12;
            this.start_day.Text = "-";
            // 
            // type_file
            // 
            this.type_file.AutoSize = true;
            this.type_file.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_file.Location = new System.Drawing.Point(140, 116);
            this.type_file.Name = "type_file";
            this.type_file.Size = new System.Drawing.Size(16, 23);
            this.type_file.TabIndex = 13;
            this.type_file.Text = "-";
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 261);
            this.Controls.Add(this.type_file);
            this.Controls.Add(this.start_day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.fon);
            this.Controls.Add(this.line);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(615, 300);
            this.MinimumSize = new System.Drawing.Size(615, 300);
            this.Name = "Answer";
            this.Text = "Результат проверки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DecorTextBox line;
        private System.Windows.Forms.TextBox fon;
        private DecorButton enter;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label start_day;
        private System.Windows.Forms.Label type_file;
    }
}