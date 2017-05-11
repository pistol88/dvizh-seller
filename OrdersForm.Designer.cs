namespace DvizhSeller
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.ordersListGridView = new System.Windows.Forms.DataGridView();
            this.DvizhId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementsListGridView = new System.Windows.Forms.DataGridView();
            this.orderElementProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementCancelAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementsBox = new System.Windows.Forms.GroupBox();
            this.canceSelectedElement = new System.Windows.Forms.Button();
            this.orderElementProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsListGridView)).BeginInit();
            this.orderElementsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderElementProviderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersListGridView
            // 
            this.ordersListGridView.AutoGenerateColumns = false;
            this.ordersListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DvizhId,
            this.totalDataGridViewTextBoxColumn});
            this.ordersListGridView.DataSource = this.orderProviderBindingSource;
            this.ordersListGridView.Location = new System.Drawing.Point(12, 12);
            this.ordersListGridView.MultiSelect = false;
            this.ordersListGridView.Name = "ordersListGridView";
            this.ordersListGridView.ReadOnly = true;
            this.ordersListGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ordersListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersListGridView.Size = new System.Drawing.Size(246, 337);
            this.ordersListGridView.TabIndex = 2;
            this.ordersListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersListGridView_CellClick);
            // 
            // DvizhId
            // 
            this.DvizhId.DataPropertyName = "DvizhId";
            this.DvizhId.HeaderText = "DvizhId";
            this.DvizhId.Name = "DvizhId";
            this.DvizhId.ReadOnly = true;
            this.DvizhId.Width = 60;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 140;
            // 
            // orderProviderBindingSource
            // 
            this.orderProviderBindingSource.DataSource = typeof(DvizhSeller.tools.OrderProvider);
            // 
            // cartDataBindingSource
            // 
            this.cartDataBindingSource.DataSource = typeof(DvizhSeller.tools.CartProvider);
            // 
            // elementsListGridView
            // 
            this.elementsListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementsListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.elementsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementsListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderElementProduct,
            this.orderElementPrice,
            this.orderElementQuantity,
            this.orderElementCancelAt,
            this.orderElementId});
            this.elementsListGridView.GridColor = System.Drawing.SystemColors.Control;
            this.elementsListGridView.Location = new System.Drawing.Point(6, 19);
            this.elementsListGridView.MultiSelect = false;
            this.elementsListGridView.Name = "elementsListGridView";
            this.elementsListGridView.ReadOnly = true;
            this.elementsListGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.elementsListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elementsListGridView.Size = new System.Drawing.Size(464, 283);
            this.elementsListGridView.StandardTab = true;
            this.elementsListGridView.TabIndex = 3;
            // 
            // orderElementProduct
            // 
            this.orderElementProduct.DataPropertyName = "ProductName";
            this.orderElementProduct.HeaderText = "Товар";
            this.orderElementProduct.Name = "orderElementProduct";
            this.orderElementProduct.ReadOnly = true;
            this.orderElementProduct.Width = 200;
            // 
            // orderElementPrice
            // 
            this.orderElementPrice.DataPropertyName = "Price";
            this.orderElementPrice.HeaderText = "Цена";
            this.orderElementPrice.Name = "orderElementPrice";
            this.orderElementPrice.ReadOnly = true;
            this.orderElementPrice.Width = 50;
            // 
            // orderElementQuantity
            // 
            this.orderElementQuantity.DataPropertyName = "Count";
            this.orderElementQuantity.HeaderText = "Кол-во";
            this.orderElementQuantity.Name = "orderElementQuantity";
            this.orderElementQuantity.ReadOnly = true;
            this.orderElementQuantity.Width = 50;
            // 
            // orderElementCancelAt
            // 
            this.orderElementCancelAt.DataPropertyName = "CancelAt";
            this.orderElementCancelAt.HeaderText = "Анулирован";
            this.orderElementCancelAt.Name = "orderElementCancelAt";
            this.orderElementCancelAt.ReadOnly = true;
            this.orderElementCancelAt.Width = 120;
            // 
            // orderElementId
            // 
            this.orderElementId.DataPropertyName = "Id";
            this.orderElementId.HeaderText = "id";
            this.orderElementId.Name = "orderElementId";
            this.orderElementId.ReadOnly = true;
            this.orderElementId.Visible = false;
            this.orderElementId.Width = 5;
            // 
            // orderElementsBox
            // 
            this.orderElementsBox.Controls.Add(this.canceSelectedElement);
            this.orderElementsBox.Controls.Add(this.elementsListGridView);
            this.orderElementsBox.Location = new System.Drawing.Point(264, 12);
            this.orderElementsBox.Name = "orderElementsBox";
            this.orderElementsBox.Size = new System.Drawing.Size(476, 337);
            this.orderElementsBox.TabIndex = 4;
            this.orderElementsBox.TabStop = false;
            this.orderElementsBox.Text = "Состав заказа";
            this.orderElementsBox.Visible = false;
            // 
            // canceSelectedElement
            // 
            this.canceSelectedElement.BackColor = System.Drawing.Color.Salmon;
            this.canceSelectedElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canceSelectedElement.Location = new System.Drawing.Point(384, 308);
            this.canceSelectedElement.Name = "canceSelectedElement";
            this.canceSelectedElement.Size = new System.Drawing.Size(86, 23);
            this.canceSelectedElement.TabIndex = 4;
            this.canceSelectedElement.Text = "Аннулировать";
            this.canceSelectedElement.UseVisualStyleBackColor = false;
            this.canceSelectedElement.Click += new System.EventHandler(this.canceSelectedElement_Click);
            // 
            // orderElementProviderBindingSource
            // 
            this.orderElementProviderBindingSource.DataSource = typeof(DvizhSeller.tools.OrderElementProvider);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 361);
            this.Controls.Add(this.orderElementsBox);
            this.Controls.Add(this.ordersListGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsListGridView)).EndInit();
            this.orderElementsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderElementProviderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ordersListGridView;
        private System.Windows.Forms.DataGridView elementsListGridView;
        private System.Windows.Forms.BindingSource cartDataBindingSource;
        private System.Windows.Forms.BindingSource orderProviderBindingSource;
        private System.Windows.Forms.GroupBox orderElementsBox;
        private System.Windows.Forms.Button canceSelectedElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvizhId;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderElementProviderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementCancelAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementId;
    }
}