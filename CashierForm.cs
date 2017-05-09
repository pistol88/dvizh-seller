using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DvizhSeller
{
    public partial class CashierForm : Form
    {
        CashierChooseForm cashierForm;

        repositories.Category categories = new repositories.Category();
        repositories.Product products = new repositories.Product();
        repositories.Client clients = new repositories.Client();
        repositories.Cashier cashiers = new repositories.Cashier();
        repositories.Order orders = new repositories.Order();
        repositories.Cart cart = new repositories.Cart();
        repositories.Discount discounts = new repositories.Discount();
        tools.CartProvider cartData = new tools.CartProvider();

        entities.Product selectedProduct;
        entities.Product cartElementSelected;
        int selectedClientId = 0;
        int selectedCashierId = 0;
        int selectedDiscountId = 0;

        services.DataMapper dataMapper;
        services.DataExchanger dataExchanger = new services.DataExchanger();
        services.Fiscal fiscal;

        bool shiftOpen;
        bool fiscalActivated;

        public CashierForm()
        {
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            dataMapper = new services.DataMapper();
            dataMapper.FillCategories(categories);
            dataMapper.FillProducts(products, categories);
            dataMapper.FillDiscounts(discounts);
            dataMapper.FillClients(clients);
            dataMapper.FillCashiers(cashiers);

            fiscal = new services.Fiscal(cart);

            RenderProducts(products.GetList());
            RenderCategories(categories.GetList());

            if (Properties.Settings.Default.fiscal && fiscal.DriverExists())
                ActivateFiscal();
            else
                DeactivateFiscal();

            RenderShift();

            cashierForm = new CashierChooseForm(this);
            cashierForm.Show();
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

        private void RenderProducts(List<entities.Product> products)
        {
            productsListView.Items.Clear();

            foreach (entities.Product product in products)
            {
                Item item = new Item(product.GetName(), product.GetId());

                dynamic row = productsListView.Items.Add(product.GetName());

                row.Tag = item.Value;

                int index = row.Index;

                productsListView.Items[index].SubItems.Add(product.GetPrice().ToString());
            }
        }

        private void RenderCategories(List<entities.Category> categories)
        {
            productsCategoriesComboBox.Items.Clear();

            Item defaultItem = new Item("Все", 0);
            productsCategoriesComboBox.Items.Add(defaultItem);

            foreach (entities.Category category in categories)
            {
                Item item = new Item(category.GetName(), category.GetId());
                productsCategoriesComboBox.Items.Add(item);
            }
        }

        private void HideProductBox()
        {
            productBox.Visible = false;
        }

        private void RenderSelectedProduct(entities.Product product)
        {
            productPrice.Text = product.GetPrice().ToString() + Properties.Settings.Default.currency;
            productSku.Text = product.GetSku();
            productCount.Value = 1;
            productBox.Text = product.GetName();
            productBox.Visible = true;
            productAmount.Text = product.GetAmount().ToString();
            productPicture.ImageLocation = product.GetImage();
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

        private void PutToCart()
        {
            cart.Put(selectedProduct, Convert.ToInt16(productCount.Value));

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

        private void productsSearchBox_Click(object sender, EventArgs e)
        {
            if (productsSearchBox.Text == "Название или штрихкод")
                productsSearchBox.Text = "";
        }

        private void productsCategoriesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Item item = (Item)productsCategoriesComboBox.SelectedItem;

            if(item.Value == 0)
                RenderProducts(products.GetList());
            else
                RenderProducts(products.FindByCategoryId(item.Value));
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

        private void productsSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(productsSearchBox.Text == "")
                RenderProducts(products.GetList());
            else
                RenderProducts(products.FindByString(productsSearchBox.Text));
        }

        private void productsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in productsListView.SelectedItems)
            {
                selectedProduct = products.FindOne(Convert.ToInt32(item.Tag));
            }

            RenderSelectedProduct(selectedProduct);
            //HideSelectedCartElement();
        }

        private void productsListView_DoubleClick(object sender, EventArgs e)
        {
            PutToCart();
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            PutToCart();
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
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (cart.GetElements().Count <= 0)
                return;

            entities.Order order = new entities.Order(0, DateTime.Now.ToString(), cart.GetTotal(), selectedCashierId, selectedClientId, selectedDiscountId);

            foreach(entities.Product product in cart.GetElements())
            {
                entities.OrderElement orderElement = new entities.OrderElement(0, product.GetId(), product.GetName(), product.GetPrice(), product.GetCartCount(), "");

                order.AddElement(orderElement);
            }

            if(Properties.Settings.Default.fiscal)
            {
                string cashierName;

                if(selectedCashierId > 0)
                {
                    entities.Cashier cashier = cashiers.FindOne(selectedCashierId);
                    cashierName = cashier.GetName();
                }
                else
                {
                    cashierName = "Основной";
                }

                int paymentType;

                if (paymentType0.Checked)
                    paymentType = 0;
                else
                    paymentType = 3;

                FiscalRegister(cashierName, paymentType);
            }

            cart.Clear();

            if(Properties.Settings.Default.online)
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

        public void ClearClient()
        {
            selectedClientId = 0;
            clientName.Text = "-";
        }

        public void ClearDiscount()
        {
            cart.UnsetDiscount();
            selectedDiscountId = 0;
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
                RenderProducts(products.GetList());
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка категорий");
                dataExchanger.LoadCategories(categories);
                RenderCategories(categories.GetList());
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка клиентов");
                dataExchanger.LoadClients(clients);
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка скидок");
                dataExchanger.LoadDiscounts(discounts);
                loadWindow.Step();

                loadWindow.SetMessage("Загрузка кассирова");
                dataExchanger.LoadCashiers(cashiers);
                loadWindow.Step();

                loadWindow.SetMessage("Обмен заказами");
                dataExchanger.SendOrders();
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

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.Show();
        }

        private void openShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fiscal.OpenShift())
            {
                MessageBox.Show("Не удалось соединиться с ККМ. Проверите, что драйвер Атол ККМ установлен и настроен корректно.");
            }

            RenderShift();
        }

        private void closeShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fiscal.CloseShift())
            {
                MessageBox.Show("Не удалось соединиться с ККМ. Проверите, что драйвер Атол ККМ установлен и настроен корректно.");
            }

            RenderShift();
        }

        private Boolean FiscalRegister(string cashierName, int paymentType)
        {
            if (!shiftOpen)
            {
                MessageBox.Show("Смена не запущена, не удается провести заказ.");

                return false;
            }

            if (!fiscal.Register(cashierName, paymentType))
            {
                MessageBox.Show("Не удалось соединиться с ККМ. Проверите, что драйвер Атол ККМ установлен и настроен корректно.");

                return false;
            }

            return true;
        }

        public void RenderShift()
        {
            shiftOpen = fiscal.SessionOpened();

            if (shiftOpen)
            {
                shiftOpened.Text = "Смена открыта";
                openShiftToolStripMenuItem.Enabled = false;
                closeShiftToolStripMenuItem.Enabled = true;
            }
            else
            {
                shiftOpened.Text = "Смена не открыта";
                openShiftToolStripMenuItem.Enabled = true;
                closeShiftToolStripMenuItem.Enabled = false;
            }
        }
    }
}
