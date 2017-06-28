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
            this.productsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.productSku = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.NumericUpDown();
            this.productPrice = new System.Windows.Forms.Label();
            this.toCartButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addProdutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addProductNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addProductSkuBox = new System.Windows.Forms.TextBox();
            this.addProductPriceBox = new System.Windows.Forms.TextBox();
            this.categoryProviderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.productsTabControl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProviderBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(644, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.productsTabControl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.productsGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // productsTabControl
            // 
            this.productsTabControl.Controls.Add(this.tabPage4);
            this.productsTabControl.Controls.Add(this.tabPage5);
            this.productsTabControl.Location = new System.Drawing.Point(9, 241);
            this.productsTabControl.Name = "productsTabControl";
            this.productsTabControl.SelectedIndex = 0;
            this.productsTabControl.Size = new System.Drawing.Size(621, 215);
            this.productsTabControl.TabIndex = 8;
            this.productsTabControl.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(613, 189);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Просмотр";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.productAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.productPicture);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.productSku);
            this.groupBox2.Controls.Add(this.productCount);
            this.groupBox2.Controls.Add(this.productPrice);
            this.groupBox2.Controls.Add(this.toCartButton);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 177);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Название товара";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(135, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Остаток:";
            // 
            // productAmount
            // 
            this.productAmount.AutoSize = true;
            this.productAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productAmount.Location = new System.Drawing.Point(193, 47);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(13, 13);
            this.productAmount.TabIndex = 11;
            this.productAmount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(135, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Артикул:";
            // 
            // productPicture
            // 
            this.productPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.productPicture.ErrorImage = null;
            this.productPicture.ImageLocation = "http://dvizh.net/images/placeholder-product.png";
            this.productPicture.Location = new System.Drawing.Point(6, 27);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(120, 120);
            this.productPicture.TabIndex = 6;
            this.productPicture.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "=";
            // 
            // productSku
            // 
            this.productSku.AutoSize = true;
            this.productSku.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productSku.Location = new System.Drawing.Point(192, 27);
            this.productSku.Name = "productSku";
            this.productSku.Size = new System.Drawing.Size(29, 13);
            this.productSku.TabIndex = 7;
            this.productSku.Text = "SKU";
            // 
            // productCount
            // 
            this.productCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCount.Location = new System.Drawing.Point(395, 29);
            this.productCount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.productCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(75, 31);
            this.productCount.TabIndex = 5;
            this.productCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productPrice.Location = new System.Drawing.Point(157, 68);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(24, 25);
            this.productPrice.TabIndex = 1;
            this.productPrice.Text = "0";
            // 
            // toCartButton
            // 
            this.toCartButton.BackColor = System.Drawing.Color.Transparent;
            this.toCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toCartButton.Location = new System.Drawing.Point(395, 66);
            this.toCartButton.Name = "toCartButton";
            this.toCartButton.Size = new System.Drawing.Size(75, 31);
            this.toCartButton.TabIndex = 0;
            this.toCartButton.Text = "В корзину";
            this.toCartButton.UseVisualStyleBackColor = false;
            this.toCartButton.Click += new System.EventHandler(this.toCartButton_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.deleteButton);
            this.tabPage5.Controls.Add(this.saveButton);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.productPriceBox);
            this.tabPage5.Controls.Add(this.productSkuBox);
            this.tabPage5.Controls.Add(this.productNameBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(613, 189);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Редактирование";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(139, 114);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.PaleGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(18, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Наименование";
            // 
            // productPriceBox
            // 
            this.productPriceBox.Location = new System.Drawing.Point(314, 78);
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(86, 20);
            this.productPriceBox.TabIndex = 10;
            // 
            // productSkuBox
            // 
            this.productSkuBox.Location = new System.Drawing.Point(17, 78);
            this.productSkuBox.Name = "productSkuBox";
            this.productSkuBox.Size = new System.Drawing.Size(291, 20);
            this.productSkuBox.TabIndex = 9;
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(17, 37);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(381, 20);
            this.productNameBox.TabIndex = 8;
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
            this.searchBox.Size = new System.Drawing.Size(572, 20);
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
            this.productsGridView.Location = new System.Drawing.Point(9, 34);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(617, 201);
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
            this.priceDataGridViewTextBoxColumn1.Width = 80;
            // 
            // productProviderBindingSource
            // 
            this.productProviderBindingSource.DataSource = typeof(DvizhSeller.tools.ProductProvider);
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
            this.tabPage2.Size = new System.Drawing.Size(636, 462);
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
            // addProductNameBox
            // 
            this.addProductNameBox.Location = new System.Drawing.Point(21, 44);
            this.addProductNameBox.Name = "addProductNameBox";
            this.addProductNameBox.Size = new System.Drawing.Size(381, 20);
            this.addProductNameBox.TabIndex = 0;
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
            // addProductSkuBox
            // 
            this.addProductSkuBox.Location = new System.Drawing.Point(21, 85);
            this.addProductSkuBox.Name = "addProductSkuBox";
            this.addProductSkuBox.Size = new System.Drawing.Size(291, 20);
            this.addProductSkuBox.TabIndex = 1;
            // 
            // addProductPriceBox
            // 
            this.addProductPriceBox.Location = new System.Drawing.Point(318, 85);
            this.addProductPriceBox.Name = "addProductPriceBox";
            this.addProductPriceBox.Size = new System.Drawing.Size(86, 20);
            this.addProductPriceBox.TabIndex = 2;
            // 
            // categoryProviderBindingSource1
            // 
            this.categoryProviderBindingSource1.DataSource = typeof(DvizhSeller.tools.CategoryProvider);
            // 
            // categoryProviderBindingSource
            // 
            this.categoryProviderBindingSource.DataSource = typeof(DvizhSeller.tools.CategoryProvider);
            // 
            // ShopBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 512);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Справочник магазина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopBookForm_FormClosing);
            this.Load += new System.EventHandler(this.ShopBookForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.productsTabControl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCount)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProviderBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProviderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.BindingSource productProviderBindingSource;
        private System.Windows.Forms.BindingSource categoryProviderBindingSource;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource categoryProviderBindingSource1;
        private System.Windows.Forms.Button addProdutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addProductPriceBox;
        private System.Windows.Forms.TextBox addProductSkuBox;
        private System.Windows.Forms.TextBox addProductNameBox;
        private System.Windows.Forms.TabControl productsTabControl;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label productAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label productSku;
        private System.Windows.Forms.NumericUpDown productCount;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Button toCartButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.TextBox productSkuBox;
        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
    }
}