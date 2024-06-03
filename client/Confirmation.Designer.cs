
namespace Freyja
{
    partial class Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.days = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter = new Freyja.DecorButton();
            this.decorButton1 = new Freyja.DecorButton();
            this.SuspendLayout();
            // 
            // days
            // 
            this.days.BackColor = System.Drawing.SystemColors.Window;
            this.days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.days.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.FormattingEnabled = true;
            this.days.Items.AddRange(new object[] {
            "1 день",
            "3 дня",
            "7 дней",
            "14 дней",
            "30 дней",
            "90 дней",
            "180 дней",
            "365 дней"});
            this.days.Location = new System.Drawing.Point(259, 40);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(174, 31);
            this.days.TabIndex = 0;
            this.days.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Срок действия подписи";
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
            this.enter.Location = new System.Drawing.Point(12, 149);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(186, 41);
            this.enter.TabIndex = 7;
            this.enter.Text = "ОК";
            this.enter.TextColor = System.Drawing.Color.Black;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // decorButton1
            // 
            this.decorButton1.BackColor = System.Drawing.SystemColors.Menu;
            this.decorButton1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.decorButton1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.decorButton1.BorderRadius = 20;
            this.decorButton1.BorderSize = 2;
            this.decorButton1.FlatAppearance.BorderSize = 0;
            this.decorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decorButton1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decorButton1.ForeColor = System.Drawing.Color.Black;
            this.decorButton1.Location = new System.Drawing.Point(286, 149);
            this.decorButton1.Name = "decorButton1";
            this.decorButton1.Size = new System.Drawing.Size(186, 41);
            this.decorButton1.TabIndex = 8;
            this.decorButton1.Text = "Отмена";
            this.decorButton1.TextColor = System.Drawing.Color.Black;
            this.decorButton1.UseVisualStyleBackColor = false;
            this.decorButton1.Click += new System.EventHandler(this.decorButton1_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.decorButton1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.days);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmation";
            this.Text = "Подтверждение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox days;
        private System.Windows.Forms.Label label1;
        private DecorButton enter;
        private DecorButton decorButton1;
    }
}