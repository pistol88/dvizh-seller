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
        repositories.Cart cart = new repositories.Cart();
        repositories.Discount discounts = new repositories.Discount();
        tools.CartData cartData = new tools.CartData();

        entities.Product selectedProduct;
        entities.Product cartElementSelected;
        int selectedClientId;
        int selectedCashierId;

        services.DataMapper dataMapper;
        services.Fiscal fiscal;

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

            fiscal = new services.Fiscal(cart);

            RenderProducts(products.GetList());
            RenderCategories(categories.GetList());

            if (Properties.Settings.Default.fiscal && fiscal.DriverExists())
                ActivateFiscal();
            else
                DeactivateFiscal();

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

        private void выбратьКассирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierChooseForm cashierForm = new CashierChooseForm(this);
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

        private void discountBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(discountBox.Text == "")
                {
                    cart.UnsetDiscount();

                    return;
                }

                entities.Discount discount = discounts.FindOneByName(discountBox.Text);

                if (discount != null)
                {
                    cart.SetDiscount(discount);
                    MessageBox.Show("Промокод применен. Скидка " + discount.GetDiscount().ToString() + "%");
                    RenderCart();
                }
                else
                {
                    MessageBox.Show("Промокод не найден");
                    discountBox.Text = "";
                }
            }
        }

        private void discountBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
