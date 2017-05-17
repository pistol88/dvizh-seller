namespace DvizhSeller
{
    partial class CashiersBookForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashiersBookForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cashierBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierNameBox = new System.Windows.Forms.TextBox();
            this.cashiersGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addCashierButton = new System.Windows.Forms.Button();
            this.addCashierNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clientProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cashierBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashiersGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientProviderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cashierBox);
            this.tabPage1.Controls.Add(this.cashiersGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кассиры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cashierBox
            // 
            this.cashierBox.Controls.Add(this.deleteButton);
            this.cashierBox.Controls.Add(this.saveButton);
            this.cashierBox.Controls.Add(this.label3);
            this.cashierBox.Controls.Add(this.cashierNameBox);
            this.cashierBox.Location = new System.Drawing.Point(6, 251);
            this.cashierBox.Name = "cashierBox";
            this.cashierBox.Size = new System.Drawing.Size(319, 125);
            this.cashierBox.TabIndex = 4;
            this.cashierBox.TabStop = false;
            this.cashierBox.Text = "Карточка кассира";
            this.cashierBox.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(86, 87);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.PaleGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(5, 87);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя кассира";
            // 
            // cashierNameBox
            // 
            this.cashierNameBox.Location = new System.Drawing.Point(5, 49);
            this.cashierNameBox.Name = "cashierNameBox";
            this.cashierNameBox.Size = new System.Drawing.Size(303, 20);
            this.cashierNameBox.TabIndex = 0;
            // 
            // cashiersGridView
            // 
            this.cashiersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashiersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.cashiersGridView.Location = new System.Drawing.Point(1, 0);
            this.cashiersGridView.Name = "cashiersGridView";
            this.cashiersGridView.ReadOnly = true;
            this.cashiersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cashiersGridView.Size = new System.Drawing.Size(326, 245);
            this.cashiersGridView.TabIndex = 0;
            this.cashiersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashiersGridView_CellClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 260;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addCashierButton);
            this.tabPage2.Controls.Add(this.addCashierNameBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Новый кассир +";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addCashierButton
            // 
            this.addCashierButton.BackColor = System.Drawing.Color.PaleGreen;
            this.addCashierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCashierButton.Location = new System.Drawing.Point(22, 83);
            this.addCashierButton.Name = "addCashierButton";
            this.addCashierButton.Size = new System.Drawing.Size(75, 23);
            this.addCashierButton.TabIndex = 9;
            this.addCashierButton.Text = "Добавить";
            this.addCashierButton.UseVisualStyleBackColor = false;
            this.addCashierButton.Click += new System.EventHandler(this.addCashierButton_Click);
            // 
            // addCashierNameBox
            // 
            this.addCashierNameBox.Location = new System.Drawing.Point(22, 44);
            this.addCashierNameBox.Name = "addCashierNameBox";
            this.addCashierNameBox.Size = new System.Drawing.Size(286, 20);
            this.addCashierNameBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Имя кассира";
            // 
            // clientProviderBindingSource
            // 
            this.clientProviderBindingSource.DataSource = typeof(DvizhSeller.tools.ProductProvider);
            // 
            // CashiersBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 435);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashiersBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник кассиров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CashiersBookForm_FormClosed);
            this.Load += new System.EventHandler(this.CashiersBookForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cashierBox.ResumeLayout(false);
            this.cashierBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashiersGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientProviderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView cashiersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource clientProviderBindingSource;
        private System.Windows.Forms.Button addCashierButton;
        private System.Windows.Forms.TextBox addCashierNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox cashierBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cashierNameBox;
    }
}