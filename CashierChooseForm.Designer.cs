namespace DvizhSeller
{
    partial class CashierChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierChooseForm));
            this.cashiersList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashiersList
            // 
            this.cashiersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashiersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashiersList.Location = new System.Drawing.Point(12, 36);
            this.cashiersList.Name = "cashiersList";
            this.cashiersList.Size = new System.Drawing.Size(260, 32);
            this.cashiersList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите кассира";
            // 
            // chooseButton
            // 
            this.chooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseButton.Location = new System.Drawing.Point(98, 78);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(80, 33);
            this.chooseButton.TabIndex = 2;
            this.chooseButton.Text = "Войти";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // CashierChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cashiersList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashierChooseForm";
            this.Text = "Выбор кассира";
            this.Load += new System.EventHandler(this.CashierChooseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cashiersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseButton;
    }
}