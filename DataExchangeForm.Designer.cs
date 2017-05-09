namespace DvizhSeller
{
    partial class DataExchangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataExchangeForm));
            this.totalProgressBar = new System.Windows.Forms.ProgressBar();
            this.messageBox = new System.Windows.Forms.Label();
            this.messageBox2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalProgressBar
            // 
            this.totalProgressBar.Location = new System.Drawing.Point(12, 27);
            this.totalProgressBar.Maximum = 7;
            this.totalProgressBar.Name = "totalProgressBar";
            this.totalProgressBar.Size = new System.Drawing.Size(438, 23);
            this.totalProgressBar.TabIndex = 0;
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.Location = new System.Drawing.Point(13, 57);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(61, 13);
            this.messageBox.TabIndex = 1;
            this.messageBox.Text = "Состояние";
            this.messageBox.Visible = false;
            // 
            // messageBox2
            // 
            this.messageBox2.AutoSize = true;
            this.messageBox2.Location = new System.Drawing.Point(13, 73);
            this.messageBox2.Name = "messageBox2";
            this.messageBox2.Size = new System.Drawing.Size(34, 13);
            this.messageBox2.TabIndex = 2;
            this.messageBox2.Text = "         ";
            this.messageBox2.Visible = false;
            // 
            // DataExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 95);
            this.Controls.Add(this.messageBox2);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.totalProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataExchangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обмен данными";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DataExchangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar totalProgressBar;
        private System.Windows.Forms.Label messageBox;
        private System.Windows.Forms.Label messageBox2;
    }
}