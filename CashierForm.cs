using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Ports;

namespace DvizhSeller
{
    public partial class CashierForm : Form
    {
        CashierChooseForm cashierForm;

        services.Database db;

        repositories.Category categories;
        repositories.Product products;
        repositories.Client clients;
        repositories.Cashier cashiers;
        repositories.Order orders;
        repositories.Cart cart;
        repositories.Discount discounts;

        tools.CartProvider cartData = new tools.CartProvider();
        
        entities.Product cartElementSelected;

        int selectedClientId = 0;
        int selectedCashierId = 0;
        int selectedDiscountId = 0;
        int selectedDiscountVal = 0;

        services.DataMapper dataMapper;
        services.DataExchanger dataExchanger;
        services.Fiscal fiscal;

        bool SessionOpen;
        bool fiscalActivated;

        string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        
        public CashierForm()
        {
            if (!File.Exists(applicationDataPath + "\\dvizh-main-database.db"))
            {
                File.Copy("database.db", applicationDataPath + "\\dvizh-main-database.db");

                if(Properties.Settings.Default.dbFile == "database.db")
                {
                    Properties.Settings.Default.dbFile = applicationDataPath + "\\dvizh-main-database.db";
                    Properties.Settings.Default.Save();
                }
            }

            db = new services.Database();
            
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            BarCodeFocus();

            clients = new repositories.Client(db);
            cashiers = new repositories.Cashier(db);
            orders = new repositories.Order(db);
            cart = new repositories.Cart();
            discounts = new repositories.Discount(db);

            dataExchanger = new services.DataExchanger(db);

            SetProductsList();
            dataMapper.FillDiscounts(discounts);
            dataMapper.FillClients(clients);
            dataMapper.FillCashiers(cashiers);

            if(Properties.Settings.Default.autoOpenTablet)
            {
                TabletForm tabletWindow = new TabletForm(this);
                tabletWindow.Show();
            }

            if (Properties.Settings.Default.fiscal)
            {
                fiscal = new services.Fiscal(new drivers.FiscalAbstractFabric(), cart);

                if (fiscal.Ready())
                    ActivateFiscal();
                else
                {
                    MessageBox.Show("Не удалось подключиться к ККТ. Попробуйте перезапустить программу.");
                    DeactivateFiscal();
                }

                if (Properties.Settings.Default.fiscalDriverType == 1)
                    discountBox.Enabled = true;

                RenderSession();

            } else
            {
                discountBox.Enabled = true;
                DeactivateFiscal();
            }
            
            cashierForm = new CashierChooseForm(this);
            cashierForm.Show();
        }

        public void BarCodeFocus()
        {
            barCodeBox.Select();
            barCodeBox.Focus();
        }

        public void SetProductsList()
        {
            products = new repositories.Product(db);
            categories = new repositories.Category(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillCategories(categories);
            dataMapper.FillProducts(products, categories);
        }

        public void ChooseCashier(int id, string name)
        {
            selectedCashierId = id;
            cashierName.Text = name;
        }

        public void ChooseClient(int id, string name)
        {
            selectedClientId = id;
            clientName.Text = name;
        }

        public void ActivateFiscal()
        {
            fiscalActivated = true;
            cashboxToolStripMenuItem.Enabled = true;
        }

        public void DeactivateFiscal()
        {
            fiscalActivated = false;
            cashboxToolStripMenuItem.Enabled = false;
        }

        public void ReRenderAllCashiers()
        {
            cashiers.Clear();
            dataMapper.FillCashiers(cashiers);
        }

        private void RenderCart()
        {
            cartData.Clear();
            foreach(entities.Product product in cart.GetElements())
            {
                cartData.Add(product);
            }
            cartGridView.DataSource = cartData;

            orderTotal.Text = cart.GetTotal().ToString() + Properties.Settings.Default.currency;
        }

        public void PutToCart(entities.Product product, int count = 1)
        {
            cart.Put(product, count);

            cartBox.Visible = true;
    
            RenderCart();
        }

        public void BuyBySku(string sku)
        {
            entities.Product product = products.FindOneBySku(sku);

            if (product != null)
                cart.Put(product);
            else
                MessageBox.Show("Товар не найден");

            RenderCart();
        }

        private class Item
        {
            public string Name;
            public int Value;

            public Item(string name, int value)
            {
                Name = name; Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void cartElementRemove_Click(object sender, EventArgs e)
        {
            cart.Delete(cartElementSelected);
            
            RenderCart();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);

            settingsForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientChooseForm clientsForm = new ClientChooseForm(this);

            clientsForm.Show();
        }


        private void cashierName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cashierForm = new CashierChooseForm(this);
            cashierForm.Show();
        }

        private void barCodeScanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarcodeScanerForm bcsForm = new BarcodeScanerForm(this);

            bcsForm.Show();
        }

        private void cartGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                //Удаление из корзины
                cart.GetElements().RemoveAt(cartGridView.CurrentCell.RowIndex);
                RenderCart();
            }
        }

        private void cartGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RenderCart();
        }

        private void SetDiscount(string promocode)
        {
            if (promocode == "")
            {
                cart.UnsetDiscount();

                return;
            }

            entities.Discount discount = discounts.FindOneByName(promocode);

            if (discount != null)
            {
                cart.SetDiscount(discount);
                selectedDiscountId = discount.GetId();
                selectedDiscountVal = discount.GetDiscount();
                MessageBox.Show("Промокод применен. Скидка " + discount.GetDiscount().ToString() + "%");
                RenderCart();
            }
            else
            {
                MessageBox.Show("Промокод не найден");
                discountBox.Text = "";
            }
        }

        private void discountBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetDiscount(discountBox.Text);
            }
        }

        private void ordersListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OrdersForm ordersForm = new OrdersForm(fiscal, GetCashierName());
            ordersForm.Show();
        }

        private string GetCashierName()
        {
            string selectedCashierName;

            if (selectedCashierId > 0)
            {
                entities.Cashier cashier = cashiers.FindOne(selectedCashierId);
                selectedCashierName = cashier.GetName();
            }
            else
            {
                selectedCashierName = "Основной";
            }

            return selectedCashierName;
        }

        private void AddOrder()
        {
            if (cart.GetElements().Count <= 0)
                return;

            entities.Order order = new entities.Order(0, DateTime.Now.ToString(), cart.GetTotal(), selectedCashierId, selectedClientId, selectedDiscountId);

            foreach (entities.Product product in cart.GetElements())
            {
                entities.OrderElement orderElement = new entities.OrderElement(0, product.GetId(), product.GetName(), product.GetPrice(), product.GetCartCount(), "");

                order.AddElement(orderElement);
            }

            bool ok = true;

            if (Properties.Settings.Default.fiscal)
            {
                byte paymentType;

                if (paymentType0.Checked)
                    paymentType = 0;
                else
                    paymentType = 1;

                ok = FiscalRegister(GetCashierName(), paymentType);
            }

            if (ok)
            {
                cart.Clear();

                if (Properties.Settings.Default.online)
                {
                    int dvizhOrderId = dataExchanger.SendOrder(order);
                    if (dvizhOrderId > 0)
                    {
                        order.SetDvizhId(dvizhOrderId);
                    }
                }

                orders.AddWithSql(order);

                RenderCart();
                ClearClient();
                ClearDiscount();

                paymentType0.Select();
            }

            barCodeBox.Focus();
            barCodeBox.Select();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            AddOrder();
        }

        public void ClearClient()
        {
            selectedClientId = 0;
            clientName.Text = "-";
        }

        public void ClearDiscount()
        {
            cart.UnsetDiscount();
            selectedDiscountId = 0;
            selectedDiscountVal = 0;
            discountBox.Text = "";
        }

        private void discountBox_Leave(object sender, EventArgs e)
        {
            SetDiscount(discountBox.Text);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Properties.Settings.Default.online)
            {
                MessageBox.Show("Включите в настройках онлайн режим");
                return;
            }

            DataExchangeForm loadWindow = new DataExchangeForm();
            loadWindow.Show();

            try
            {
                loadWindow.SetMessage("Загрузка товаров");
                Tuple<int, int, int>  productsResult = dataExchanger.LoadProducts(products, categories);
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка категорий");
                dataExchanger.LoadCategories(categories);
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка клиентов");
                dataExchanger.LoadClients(clients);
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка скидок");
                dataExchanger.LoadDiscounts(discounts);
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка кассиров");
                dataExchanger.LoadCashiers(cashiers);
                loadWindow.Step();

                loadWindow.SetMessage("Обмен заказами");
                dataExchanger.SendOrders(orders);
                loadWindow.Step();

                loadWindow.Step();

                loadWindow.SetMessage("Обмен завершен. Добавлено товаров: " + productsResult.Item1.ToString() + "; новых цен: " + productsResult.Item2.ToString() + "; новых остатков: " + productsResult.Item3.ToString());
            }
            catch (System.Data.SqlClient.SqlException exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show("Обмен не удалось завершить до конца");
            }
            
        }

        private void openSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiscal.OpenSession();

            RenderSession();
        }

        private void closeSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiscal.CloseSession();

            RenderSession();
        }

        private bool FiscalRegister(string cashierName, byte paymentType)
        {
            if (!SessionOpen)
            {
                MessageBox.Show("Смена фискального регистратора не запущена (либо длится более 24 часов). Не удается провести заказ.");

                return false;
            }

            bool discount = false;

            if(selectedDiscountId > 0)
            {
                discount = true;
            }

            fiscal.SetCashier(cashierName);
            fiscal.Register(paymentType);

            return true;
        }

        public void RenderSession()
        {
            SessionOpen = fiscal.IsSessionOpen();

            if (SessionOpen)
            {
                SessionOpened.Text = "Смена открыта";
                openSessionToolStripMenuItem.Enabled = false;
                closeSessionToolStripMenuItem.Enabled = true;
            }
            else
            {
                SessionOpened.Text = "Смена не открыта";
                openSessionToolStripMenuItem.Enabled = true;
                closeSessionToolStripMenuItem.Enabled = false;
            }
        }

        private void shopListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopBookForm shopbookWindow = new ShopBookForm(this);
            shopbookWindow.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsBookForm clientsbookWindow = new ClientsBookForm();
            clientsbookWindow.Show();
        }

        private void promocodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountsBookForm discountsbookWindow = new DiscountsBookForm();
            discountsbookWindow.Show();
        }

        private void barCodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            String barCodeStr = barCodeBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if(barCodeStr == "")
                {
                    AddOrder();
                }
                else
                {
                    BuyBySku(barCodeStr);
                    barCodeBox.Text = "";
                }
            }
        }

        private void barCodeBox_Click(object sender, EventArgs e)
        {
            if(barCodeBox.Text == "Купить по штрихкоду")
            {
                barCodeBox.Text = "";
            }
        }

        private void fiscalTestPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiscal.TestPrint();
        }

        private void cashiersBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashiersBookForm cashiersBookWindow = new CashiersBookForm(this);
            cashiersBookWindow.Show();
        }

        private void shopBooksLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShopBookForm shopbookWindow = new ShopBookForm(this);
            shopbookWindow.Show();
        }

        private void freeSale_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FreeSaleForm freesaleWindow = new FreeSaleForm(this);
            freesaleWindow.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.Show();
        }
    }
}
