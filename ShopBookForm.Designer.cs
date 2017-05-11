namespace DvizhSeller
{
    partial class ShopBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopBookForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProviderBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.productsGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(54, 8);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(579, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Название или штрихкод";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // productsGridView
            // 
            this.productsGridView.AutoGenerateColumns = false;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.Amount,
            this.AmountColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.productsGridView.DataSource = this.productProviderBindingSource;
            this.productsGridView.Location = new System.Drawing.Point(0, 34);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(633, 311);
            this.productsGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 260;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Sku";
            this.Amount.HeaderText = "Штрихкод";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.HeaderText = "Остаток";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productProviderBindingSource
            // 
            this.productProviderBindingSource.DataSource = typeof(DvizhSeller.tools.ProductProvider);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Новый товар +";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Недоступно в этой версии";
            // 
            // categoryProviderBindingSource
            // 
            this.categoryProviderBindingSource.DataSource = typeof(DvizhSeller.tools.CategoryProvider);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск:";
            // 
            // ShopBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 402);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник магазина";
            this.Load += new System.EventHandler(this.ShopBook_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProviderBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvizhIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productProviderBindingSource;
        private System.Windows.Forms.BindingSource categoryProviderBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
    }
}