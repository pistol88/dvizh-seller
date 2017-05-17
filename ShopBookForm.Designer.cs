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
            this.productBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productPriceBox = new System.Windows.Forms.TextBox();
            this.productSkuBox = new System.Windows.Forms.TextBox();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.categoryProviderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addProdutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addProductPriceBox = new System.Windows.Forms.TextBox();
            this.addProductSkuBox = new System.Windows.Forms.TextBox();
            this.addProductNameBox = new System.Windows.Forms.TextBox();
            this.categoryProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.productBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProviderBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.productBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.productsGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // productBox
            // 
            this.productBox.Controls.Add(this.deleteButton);
            this.productBox.Controls.Add(this.saveButton);
            this.productBox.Controls.Add(this.label5);
            this.productBox.Controls.Add(this.label4);
            this.productBox.Controls.Add(this.label3);
            this.productBox.Controls.Add(this.productPriceBox);
            this.productBox.Controls.Add(this.productSkuBox);
            this.productBox.Controls.Add(this.productNameBox);
            this.productBox.Location = new System.Drawing.Point(6, 241);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(624, 155);
            this.productBox.TabIndex = 3;
            this.productBox.TabStop = false;
            this.productBox.Text = "Карточка товара";
            this.productBox.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(126, 126);
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
            this.saveButton.Location = new System.Drawing.Point(6, 126);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Наименование";
            // 
            // productPriceBox
            // 
            this.productPriceBox.Location = new System.Drawing.Point(302, 90);
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(86, 20);
            this.productPriceBox.TabIndex = 2;
            // 
            // productSkuBox
            // 
            this.productSkuBox.Location = new System.Drawing.Point(5, 90);
            this.productSkuBox.Name = "productSkuBox";
            this.productSkuBox.Size = new System.Drawing.Size(291, 20);
            this.productSkuBox.TabIndex = 1;
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(5, 49);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(381, 20);
            this.productNameBox.TabIndex = 0;
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
            this.productsGridView.Size = new System.Drawing.Size(633, 201);
            this.productsGridView.TabIndex = 0;
            this.productsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellClick);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.categoriesGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(636, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Категории";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AutoGenerateColumns = false;
            this.categoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryNameColumn});
            this.categoriesGridView.DataSource = this.categoryProviderBindingSource1;
            this.categoriesGridView.Location = new System.Drawing.Point(4, 4);
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.Size = new System.Drawing.Size(629, 395);
            this.categoriesGridView.TabIndex = 0;
            // 
            // categoryProviderBindingSource1
            // 
            this.categoryProviderBindingSource1.DataSource = typeof(DvizhSeller.tools.CategoryProvider);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addProdutButton);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.addProductNameBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.addProductSkuBox);
            this.tabPage2.Controls.Add(this.addProductPriceBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Новый товар +";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addProdutButton
            // 
            this.addProdutButton.BackColor = System.Drawing.Color.PaleGreen;
            this.addProdutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProdutButton.Location = new System.Drawing.Point(22, 121);
            this.addProdutButton.Name = "addProdutButton";
            this.addProdutButton.Size = new System.Drawing.Size(75, 23);
            this.addProdutButton.TabIndex = 6;
            this.addProdutButton.Text = "Добавить";
            this.addProdutButton.UseVisualStyleBackColor = false;
            this.addProdutButton.Click += new System.EventHandler(this.addProdutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Артикул";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Наименование";
            // 
            // addProductPriceBox
            // 
            this.addProductPriceBox.Location = new System.Drawing.Point(318, 85);
            this.addProductPriceBox.Name = "addProductPriceBox";
            this.addProductPriceBox.Size = new System.Drawing.Size(86, 20);
            this.addProductPriceBox.TabIndex = 2;
            // 
            // addProductSkuBox
            // 
            this.addProductSkuBox.Location = new System.Drawing.Point(21, 85);
            this.addProductSkuBox.Name = "addProductSkuBox";
            this.addProductSkuBox.Size = new System.Drawing.Size(291, 20);
            this.addProductSkuBox.TabIndex = 1;
            // 
            // addProductNameBox
            // 
            this.addProductNameBox.Location = new System.Drawing.Point(21, 44);
            this.addProductNameBox.Name = "addProductNameBox";
            this.addProductNameBox.Size = new System.Drawing.Size(381, 20);
            this.addProductNameBox.TabIndex = 0;
            // 
            // categoryProviderBindingSource
            // 
            this.categoryProviderBindingSource.DataSource = typeof(DvizhSeller.tools.CategoryProvider);
            // 
            // CategoryNameColumn
            // 
            this.CategoryNameColumn.DataPropertyName = "Name";
            this.CategoryNameColumn.HeaderText = "Название";
            this.CategoryNameColumn.Name = "CategoryNameColumn";
            this.CategoryNameColumn.ReadOnly = true;
            this.CategoryNameColumn.Width = 565;
            // 
            // ShopBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 452);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник магазина";
            this.Deactivate += new System.EventHandler(this.ShopBookForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopBookForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopBook_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.productBox.ResumeLayout(false);
            this.productBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProviderBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView categoriesGridView;
        private System.Windows.Forms.BindingSource categoryProviderBindingSource1;
        private System.Windows.Forms.GroupBox productBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.TextBox productSkuBox;
        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.Button addProdutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addProductPriceBox;
        private System.Windows.Forms.TextBox addProductSkuBox;
        private System.Windows.Forms.TextBox addProductNameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameColumn;
    }
}