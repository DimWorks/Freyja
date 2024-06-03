
namespace Freyja
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.output = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.line = new Freyja.DecorTextBox();
            this.ok_but = new Freyja.DecorButton();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(12, 81);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(54, 20);
            this.output.TabIndex = 0;
            this.output.Text = "label1";
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Menu;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(15, 12);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(554, 33);
            this.status.TabIndex = 2;
            this.status.TabStop = false;
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.Menu;
            this.line.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.line.BorderSize = 2;
            this.line.Enabled = false;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.line.Location = new System.Drawing.Point(15, 15);
            this.line.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.line.MaxLength = 20;
            this.line.Name = "line";
            this.line.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.line.Password = false;
            this.line.ReadOnly = true;
            this.line.Size = new System.Drawing.Size(554, 39);
            this.line.TabIndex = 1;
            this.line.TabStop = false;
            this.line.UnderLineStyle = true;
            this.line.WatermarkText = null;
            // 
            // ok_but
            // 
            this.ok_but.BackColor = System.Drawing.SystemColors.Menu;
            this.ok_but.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ok_but.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ok_but.BorderRadius = 20;
            this.ok_but.BorderSize = 2;
            this.ok_but.FlatAppearance.BorderSize = 0;
            this.ok_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_but.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_but.ForeColor = System.Drawing.Color.Black;
            this.ok_but.Location = new System.Drawing.Point(244, 110);
            this.ok_but.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ok_but.Name = "ok_but";
            this.ok_but.Size = new System.Drawing.Size(112, 32);
            this.ok_but.TabIndex = 3;
            this.ok_but.Text = "OK";
            this.ok_but.TextColor = System.Drawing.Color.Black;
            this.ok_but.UseVisualStyleBackColor = false;
            this.ok_but.Click += new System.EventHandler(this.ok_but_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(584, 159);
            this.Controls.Add(this.ok_but);
            this.Controls.Add(this.status);
            this.Controls.Add(this.line);
            this.Controls.Add(this.output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 198);
            this.MinimumSize = new System.Drawing.Size(600, 198);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с сервером";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
        private DecorTextBox line;
        private System.Windows.Forms.TextBox status;
        private DecorButton ok_but;
    }
}