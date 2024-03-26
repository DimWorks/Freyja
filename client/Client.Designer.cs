
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
            this.status = new Freyja.DecorTextBox();
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
            this.status.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.status.BorderSize = 2;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(15, 15);
            this.status.Margin = new System.Windows.Forms.Padding(6);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(7);
            this.status.Password = false;
            this.status.Size = new System.Drawing.Size(554, 39);
            this.status.TabIndex = 1;
            this.status.UnderLineStyle = true;
            this.status.WatermarkText = null;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.status);
            this.Controls.Add(this.output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Client";
            this.Text = "Работа с сервером";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
        private DecorTextBox status;
    }
}