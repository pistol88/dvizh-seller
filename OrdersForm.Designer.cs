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
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.ordersListGridView = new System.Windows.Forms.DataGridView();
            this.orderProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementsListGridView = new System.Windows.Forms.DataGridView();
            this.dvizhIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderElementsBox = new System.Windows.Forms.GroupBox();
            this.canceSelectedElement = new System.Windows.Forms.Button();
            this.orderTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsListGridView)).BeginInit();
            this.orderElementsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(12, 12);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(246, 20);
            this.dateStart.TabIndex = 0;
            // 
            // ordersListGridView
            // 
            this.ordersListGridView.AutoGenerateColumns = false;
            this.ordersListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvizhIdDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.ordersListGridView.DataSource = this.orderProviderBindingSource;
            this.ordersListGridView.Location = new System.Drawing.Point(12, 39);
            this.ordersListGridView.MultiSelect = false;
            this.ordersListGridView.Name = "ordersListGridView";
            this.ordersListGridView.ReadOnly = true;
            this.ordersListGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ordersListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersListGridView.Size = new System.Drawing.Size(246, 310);
            this.ordersListGridView.TabIndex = 2;
            this.ordersListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersListGridView_CellClick);
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
            this.orderElementId});
            this.elementsListGridView.GridColor = System.Drawing.SystemColors.Control;
            this.elementsListGridView.Location = new System.Drawing.Point(6, 47);
            this.elementsListGridView.MultiSelect = false;
            this.elementsListGridView.Name = "elementsListGridView";
            this.elementsListGridView.ReadOnly = true;
            this.elementsListGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.elementsListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elementsListGridView.Size = new System.Drawing.Size(345, 241);
            this.elementsListGridView.StandardTab = true;
            this.elementsListGridView.TabIndex = 3;
            // 
            // dvizhIdDataGridViewTextBoxColumn
            // 
            this.dvizhIdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.dvizhIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dvizhIdDataGridViewTextBoxColumn.Name = "dvizhIdDataGridViewTextBoxColumn";
            this.dvizhIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.dvizhIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 140;
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
            this.orderElementsBox.Controls.Add(this.orderTotal);
            this.orderElementsBox.Controls.Add(this.canceSelectedElement);
            this.orderElementsBox.Controls.Add(this.elementsListGridView);
            this.orderElementsBox.Location = new System.Drawing.Point(273, 26);
            this.orderElementsBox.Name = "orderElementsBox";
            this.orderElementsBox.Size = new System.Drawing.Size(357, 323);
            this.orderElementsBox.TabIndex = 4;
            this.orderElementsBox.TabStop = false;
            this.orderElementsBox.Text = "Состав заказа";
            this.orderElementsBox.Visible = false;
            // 
            // canceSelectedElement
            // 
            this.canceSelectedElement.BackColor = System.Drawing.Color.Salmon;
            this.canceSelectedElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canceSelectedElement.Location = new System.Drawing.Point(265, 294);
            this.canceSelectedElement.Name = "canceSelectedElement";
            this.canceSelectedElement.Size = new System.Drawing.Size(86, 23);
            this.canceSelectedElement.TabIndex = 4;
            this.canceSelectedElement.Text = "Анулировать";
            this.canceSelectedElement.UseVisualStyleBackColor = false;
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSize = true;
            this.orderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTotal.Location = new System.Drawing.Point(231, 19);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(120, 25);
            this.orderTotal.TabIndex = 5;
            this.orderTotal.Text = "orderTotal";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 361);
            this.Controls.Add(this.orderElementsBox);
            this.Controls.Add(this.ordersListGridView);
            this.Controls.Add(this.dateStart);
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
            this.orderElementsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DataGridView ordersListGridView;
        private System.Windows.Forms.DataGridView elementsListGridView;
        private System.Windows.Forms.BindingSource cartDataBindingSource;
        private System.Windows.Forms.BindingSource orderProviderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvizhIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderElementId;
        private System.Windows.Forms.GroupBox orderElementsBox;
        private System.Windows.Forms.Button canceSelectedElement;
        private System.Windows.Forms.Label orderTotal;
    }
}