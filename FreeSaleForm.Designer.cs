namespace DvizhSeller
{
    partial class FreeSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeSaleForm));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(12, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(305, 40);
            this.nameBox.TabIndex = 11;
            this.nameBox.Text = "Свободная цена";
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FreeSaleForm_KeyDown);
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceBox.Location = new System.Drawing.Point(323, 25);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(108, 40);
            this.priceBox.TabIndex = 12;
            this.priceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FreeSaleForm_KeyDown);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Наименование:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Нажмите Enter, чтобы положить товар в корзину";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Кол-во:";
            // 
            // productCount
            // 
            this.productCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.productCount.Location = new System.Drawing.Point(438, 26);
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(62, 39);
            this.productCount.TabIndex = 18;
            this.productCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FreeSaleForm_KeyDown);
            // 
            // FreeSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 107);
            this.Controls.Add(this.productCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FreeSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Свободная продажа";
            this.Load += new System.EventHandler(this.FreeSaleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FreeSaleForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown productCount;
    }
}