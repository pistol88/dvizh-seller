namespace DvizhSeller
{
    partial class CashierForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stornToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiscalTestPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barCodeScanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashiersBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartBox = new System.Windows.Forms.GroupBox();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.cartProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartProductDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.clientName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentType1 = new System.Windows.Forms.RadioButton();
            this.paymentType0 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.orderTotal = new System.Windows.Forms.Label();
            this.cashierName = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.shiftOpened = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.barCodeBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shopBooksLinkLabel = new System.Windows.Forms.LinkLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeSale = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.cartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.orderBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesToolStripMenuItem,
            this.allListsToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.listsToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashboxToolStripMenuItem,
            this.barCodeScanerToolStripMenuItem});
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.devicesToolStripMenuItem.Text = "Оборудование";
            // 
            // cashboxToolStripMenuItem
            // 
            this.cashboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openShiftToolStripMenuItem,
            this.closeShiftToolStripMenuItem,
            this.stornToolStripMenuItem,
            this.fiscalTestPrintToolStripMenuItem,
            this.fiscalToolStripMenuItem});
            this.cashboxToolStripMenuItem.Name = "cashboxToolStripMenuItem";
            this.cashboxToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cashboxToolStripMenuItem.Text = "Касса";
            // 
            // openShiftToolStripMenuItem
            // 
            this.openShiftToolStripMenuItem.Name = "openShiftToolStripMenuItem";
            this.openShiftToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openShiftToolStripMenuItem.Text = "Открыть смену";
            this.openShiftToolStripMenuItem.Click += new System.EventHandler(this.openShiftToolStripMenuItem_Click);
            // 
            // closeShiftToolStripMenuItem
            // 
            this.closeShiftToolStripMenuItem.Name = "closeShiftToolStripMenuItem";
            this.closeShiftToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeShiftToolStripMenuItem.Text = "Закрыть смену";
            this.closeShiftToolStripMenuItem.Click += new System.EventHandler(this.closeShiftToolStripMenuItem_Click);
            // 
            // stornToolStripMenuItem
            // 
            this.stornToolStripMenuItem.Enabled = false;
            this.stornToolStripMenuItem.Name = "stornToolStripMenuItem";
            this.stornToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.stornToolStripMenuItem.Text = "Сторнирование";
            // 
            // fiscalTestPrintToolStripMenuItem
            // 
            this.fiscalTestPrintToolStripMenuItem.Name = "fiscalTestPrintToolStripMenuItem";
            this.fiscalTestPrintToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fiscalTestPrintToolStripMenuItem.Text = "Тестовая печать";
            this.fiscalTestPrintToolStripMenuItem.Click += new System.EventHandler(this.fiscalTestPrintToolStripMenuItem_Click);
            // 
            // fiscalToolStripMenuItem
            // 
            this.fiscalToolStripMenuItem.Name = "fiscalToolStripMenuItem";
            this.fiscalToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fiscalToolStripMenuItem.Text = "Настройки";
            this.fiscalToolStripMenuItem.Click += new System.EventHandler(this.fiscalToolStripMenuItem_Click);
            // 
            // barCodeScanerToolStripMenuItem
            // 
            this.barCodeScanerToolStripMenuItem.Name = "barCodeScanerToolStripMenuItem";
            this.barCodeScanerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.barCodeScanerToolStripMenuItem.Text = "Сканер штрихкода";
            this.barCodeScanerToolStripMenuItem.Click += new System.EventHandler(this.barCodeScanerToolStripMenuItem_Click);
            // 
            // allListsToolStripMenuItem
            // 
            this.allListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopListToolStripMenuItem,
            this.cashiersBookToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.promocodesToolStripMenuItem});
            this.allListsToolStripMenuItem.Name = "allListsToolStripMenuItem";
            this.allListsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.allListsToolStripMenuItem.Text = "Справочники";
            // 
            // shopListToolStripMenuItem
            // 
            this.shopListToolStripMenuItem.Name = "shopListToolStripMenuItem";
            this.shopListToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.shopListToolStripMenuItem.Text = "Магазин";
            this.shopListToolStripMenuItem.Click += new System.EventHandler(this.shopListToolStripMenuItem_Click);
            // 
            // cashiersBookToolStripMenuItem
            // 
            this.cashiersBookToolStripMenuItem.Name = "cashiersBookToolStripMenuItem";
            this.cashiersBookToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cashiersBookToolStripMenuItem.Text = "Кассиры";
            this.cashiersBookToolStripMenuItem.Click += new System.EventHandler(this.cashiersBookToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // promocodesToolStripMenuItem
            // 
            this.promocodesToolStripMenuItem.Name = "promocodesToolStripMenuItem";
            this.promocodesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.promocodesToolStripMenuItem.Text = "Промокоды";
            this.promocodesToolStripMenuItem.Click += new System.EventHandler(this.promocodesToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersListToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // ordersListToolStripMenuItem
            // 
            this.ordersListToolStripMenuItem.Name = "ordersListToolStripMenuItem";
            this.ordersListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ordersListToolStripMenuItem.Text = "Журнал заказов";
            this.ordersListToolStripMenuItem.Click += new System.EventHandler(this.ordersListToolStripMenuItem_Click);
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem});
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.listsToolStripMenuItem.Text = "Dvizh.net";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.productsToolStripMenuItem.Text = "Обновить данные";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.оПрограммеToolStripMenuItem.Text = "Программа";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.информацияToolStripMenuItem.Text = "О программе";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // cartBox
            // 
            this.cartBox.Controls.Add(this.cartGridView);
            this.cartBox.Location = new System.Drawing.Point(0, 120);
            this.cartBox.Name = "cartBox";
            this.cartBox.Size = new System.Drawing.Size(504, 173);
            this.cartBox.TabIndex = 5;
            this.cartBox.TabStop = false;
            this.cartBox.Text = "Корзина";
            // 
            // cartGridView
            // 
            this.cartGridView.AllowDrop = true;
            this.cartGridView.AllowUserToOrderColumns = true;
            this.cartGridView.AutoGenerateColumns = false;
            this.cartGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cartGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartProductName,
            this.cartProductPrice,
            this.cartProductCount,
            this.cartProductDelete,
            this.nameDataGridViewTextBoxColumn,
            this.skuDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.cartCountDataGridViewTextBoxColumn});
            this.cartGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartGridView.DataSource = this.cartDataBindingSource;
            this.cartGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.cartGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.cartGridView.Location = new System.Drawing.Point(7, 22);
            this.cartGridView.MultiSelect = false;
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartGridView.Size = new System.Drawing.Size(490, 145);
            this.cartGridView.TabIndex = 0;
            this.cartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGridView_CellClick);
            this.cartGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGridView_CellEndEdit);
            // 
            // cartProductName
            // 
            this.cartProductName.DataPropertyName = "Name";
            this.cartProductName.HeaderText = "Товар";
            this.cartProductName.Name = "cartProductName";
            this.cartProductName.ReadOnly = true;
            this.cartProductName.Width = 265;
            // 
            // cartProductPrice
            // 
            this.cartProductPrice.DataPropertyName = "Price";
            this.cartProductPrice.HeaderText = "Цена";
            this.cartProductPrice.Name = "cartProductPrice";
            this.cartProductPrice.ReadOnly = true;
            this.cartProductPrice.Width = 70;
            // 
            // cartProductCount
            // 
            this.cartProductCount.DataPropertyName = "CartCount";
            this.cartProductCount.HeaderText = "Кол-во";
            this.cartProductCount.Name = "cartProductCount";
            this.cartProductCount.Width = 70;
            // 
            // cartProductDelete
            // 
            this.cartProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartProductDelete.HeaderText = "X";
            this.cartProductDelete.Name = "cartProductDelete";
            this.cartProductDelete.ReadOnly = true;
            this.cartProductDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cartProductDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cartProductDelete.Text = "X";
            this.cartProductDelete.UseColumnTextForButtonValue = true;
            this.cartProductDelete.Width = 40;
            // 
            // orderBox
            // 
            this.orderBox.Controls.Add(this.discountBox);
            this.orderBox.Controls.Add(this.linkLabel1);
            this.orderBox.Controls.Add(this.clientName);
            this.orderBox.Controls.Add(this.shiftOpened);
            this.orderBox.Controls.Add(this.label5);
            this.orderBox.Controls.Add(this.label8);
            this.orderBox.Controls.Add(this.paymentType1);
            this.orderBox.Controls.Add(this.cashierName);
            this.orderBox.Controls.Add(this.paymentType0);
            this.orderBox.Controls.Add(this.label2);
            this.orderBox.Controls.Add(this.label1);
            this.orderBox.Controls.Add(this.orderButton);
            this.orderBox.Controls.Add(this.orderTotal);
            this.orderBox.Location = new System.Drawing.Point(7, 307);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(497, 142);
            this.orderBox.TabIndex = 6;
            this.orderBox.TabStop = false;
            this.orderBox.Text = "Заказ";
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(289, 28);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(89, 20);
            this.discountBox.TabIndex = 14;
            this.discountBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discountBox_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(284, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Выбрать клиента";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientName.Location = new System.Drawing.Point(284, 58);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(11, 13);
            this.clientName.TabIndex = 12;
            this.clientName.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Итого:";
            // 
            // paymentType1
            // 
            this.paymentType1.AutoSize = true;
            this.paymentType1.Location = new System.Drawing.Point(107, 106);
            this.paymentType1.Name = "paymentType1";
            this.paymentType1.Size = new System.Drawing.Size(61, 17);
            this.paymentType1.TabIndex = 10;
            this.paymentType1.Text = "Картой";
            this.paymentType1.UseVisualStyleBackColor = true;
            // 
            // paymentType0
            // 
            this.paymentType0.AutoSize = true;
            this.paymentType0.Checked = true;
            this.paymentType0.Location = new System.Drawing.Point(11, 106);
            this.paymentType0.Name = "paymentType0";
            this.paymentType0.Size = new System.Drawing.Size(84, 17);
            this.paymentType0.TabIndex = 9;
            this.paymentType0.TabStop = true;
            this.paymentType0.Text = "Наличными";
            this.paymentType0.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Промокод:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Клиент:";
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Honeydew;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.Location = new System.Drawing.Point(219, 99);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(160, 31);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "Заказ";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSize = true;
            this.orderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTotal.Location = new System.Drawing.Point(74, 22);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(25, 25);
            this.orderTotal.TabIndex = 1;
            this.orderTotal.Text = "0";
            // 
            // cashierName
            // 
            this.cashierName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cashierName.AutoSize = true;
            this.cashierName.Location = new System.Drawing.Point(55, 71);
            this.cashierName.Name = "cashierName";
            this.cashierName.Size = new System.Drawing.Size(51, 13);
            this.cashierName.TabIndex = 12;
            this.cashierName.TabStop = true;
            this.cashierName.Text = "Выбрать";
            this.cashierName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cashierName_LinkClicked);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Кассир";
            // 
            // shiftOpened
            // 
            this.shiftOpened.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shiftOpened.AutoSize = true;
            this.shiftOpened.BackColor = System.Drawing.Color.Transparent;
            this.shiftOpened.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shiftOpened.Location = new System.Drawing.Point(8, 84);
            this.shiftOpened.Name = "shiftOpened";
            this.shiftOpened.Size = new System.Drawing.Size(10, 13);
            this.shiftOpened.TabIndex = 16;
            this.shiftOpened.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.barCodeBox);
            this.groupBox3.Location = new System.Drawing.Point(0, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 67);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Купить по сканеру штрихкода";
            // 
            // barCodeBox
            // 
            this.barCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barCodeBox.Location = new System.Drawing.Point(7, 19);
            this.barCodeBox.Name = "barCodeBox";
            this.barCodeBox.Size = new System.Drawing.Size(333, 35);
            this.barCodeBox.TabIndex = 12;
            this.barCodeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barCodeBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.freeSale);
            this.groupBox1.Controls.Add(this.shopBooksLinkLabel);
            this.groupBox1.Location = new System.Drawing.Point(352, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 67);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Справочник";
            // 
            // shopBooksLinkLabel
            // 
            this.shopBooksLinkLabel.AutoSize = true;
            this.shopBooksLinkLabel.Location = new System.Drawing.Point(10, 19);
            this.shopBooksLinkLabel.Name = "shopBooksLinkLabel";
            this.shopBooksLinkLabel.Size = new System.Drawing.Size(113, 13);
            this.shopBooksLinkLabel.TabIndex = 15;
            this.shopBooksLinkLabel.TabStop = true;
            this.shopBooksLinkLabel.Text = "Открыть справочник";
            this.shopBooksLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.shopBooksLinkLabel_LinkClicked);
            // 
            // webBrowser
            // 
            this.webBrowser.AllowNavigation = false;
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.CausesValidation = false;
            this.webBrowser.Location = new System.Drawing.Point(5, 464);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(504, 65);
            this.webBrowser.TabIndex = 19;
            this.webBrowser.Url = new System.Uri("http://dvizh.net/info/dvizh.cashier.html", System.UriKind.Absolute);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // cartCountDataGridViewTextBoxColumn
            // 
            this.cartCountDataGridViewTextBoxColumn.DataPropertyName = "CartCount";
            this.cartCountDataGridViewTextBoxColumn.HeaderText = "CartCount";
            this.cartCountDataGridViewTextBoxColumn.Name = "cartCountDataGridViewTextBoxColumn";
            // 
            // cartDataBindingSource
            // 
            this.cartDataBindingSource.DataSource = typeof(DvizhSeller.tools.CartProvider);
            // 
            // freeSale
            // 
            this.freeSale.AutoSize = true;
            this.freeSale.Location = new System.Drawing.Point(10, 41);
            this.freeSale.Name = "freeSale";
            this.freeSale.Size = new System.Drawing.Size(109, 13);
            this.freeSale.TabIndex = 17;
            this.freeSale.TabStop = true;
            this.freeSale.Text = "Свободная продажа";
            this.freeSale.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.freeSale_LinkClicked_1);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(514, 530);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.cartBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dvizh.АРМ.Кассир";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cartBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.orderBox.ResumeLayout(false);
            this.orderBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stornToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.GroupBox cartBox;
        private System.Windows.Forms.GroupBox orderBox;
        private System.Windows.Forms.Label orderTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.RadioButton paymentType1;
        private System.Windows.Forms.RadioButton paymentType0;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barCodeScanerToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel cashierName;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.BindingSource cartDataBindingSource;
        private System.Windows.Forms.Label shiftOpened;
        private System.Windows.Forms.ToolStripMenuItem allListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiscalTestPrintToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox barCodeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProductCount;
        private System.Windows.Forms.DataGridViewButtonColumn cartProductDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem cashiersBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiscalToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel shopBooksLinkLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.LinkLabel freeSale;
    }
}

