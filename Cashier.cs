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
    public partial class Cashier : Form
    {
        repositories.Category categories = new repositories.Category();
        repositories.Product products = new repositories.Product();
        repositories.Client clients = new repositories.Client();
        repositories.Cart cart = new repositories.Cart();

        entities.Product selectedProduct;
        entities.Product cartElementSelected;
        int selectedClientId;
        int selectedCashierId;

        services.DataMapper dataMapper;
        services.Fiscal fiscal;

        bool fiscalActivated;

        public Cashier()
        {
            InitializeComponent();
        }
        
        private void Cashier_Load(object sender, EventArgs e)
        {
            dataMapper = new services.DataMapper();
            dataMapper.FillCategories(categories);
            dataMapper.FillProducts(products, categories);

            fiscal = new services.Fiscal(cart);

            RenderProducts(products.GetList());
            RenderCategories(categories.GetList());

            barCodeBox.Select();

            if (Properties.Settings.Default.fiscal && fiscal.DriverExists())
                ActivateFiscal();
            else
                DeactivateFiscal();
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
            productName.Text = product.GetName();
            productBox.Visible = true;
            productAmount.Text = product.GetAmount().ToString();
        }

        private void RenderSelectedCartElement(entities.Product product)
        {
            cartElementCount.Value = product.GetCartCount();

            cartElementBoxBox.Visible = true;
        }

        private void HideSelectedCartElement()
        {
            cartElementBoxBox.Visible = false;
        }

        private void RenderCart()
        {
            cartListView.Items.Clear();

            orderBox.Visible = false;

            foreach (entities.Product product in cart.GetElements())
            {
                orderBox.Visible = true;

                Item item = new Item(product.GetName(), product.GetId());

                dynamic row = cartListView.Items.Add(product.GetName());

                row.Tag = item.Value;

                int index = row.Index;

                cartListView.Items[index].SubItems.Add(product.GetPrice().ToString());
                cartListView.Items[index].SubItems.Add(product.GetCartCount().ToString());
            }

            orderTotal.Text = cart.GetTotal() + Properties.Settings.Default.currency;
            
        }

        private void PutToCart()
        {
            cart.Put(selectedProduct, Convert.ToInt16(productCount.Value));

            RenderCart();
        }

        private void BuyBySku(string sku)
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

        private void productsListView_Leave(object sender, EventArgs e)
        {
            
        }

        private void productsListView_DoubleClick(object sender, EventArgs e)
        {
            PutToCart();
        }

        private void productCount_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            PutToCart();
        }

        private void cartListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in cartListView.SelectedItems)
            {
                cartElementSelected = products.FindOne(Convert.ToInt32(item.Tag));
            }

            RenderSelectedCartElement(cartElementSelected);
            //HideProductBox();
        }

        private void cartElementCount_ValueChanged(object sender, EventArgs e)
        {
            cartElementSelected.SetCartCount(Convert.ToInt32(cartElementCount.Value));

            RenderCart();
        }

        private void cartElementRemove_Click(object sender, EventArgs e)
        {
            cart.Delete(cartElementSelected);

            HideSelectedCartElement();

            RenderCart();
        }

        private void productBox_Enter(object sender, EventArgs e)
        {

        }

        private void discountBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barCodeBox_TextChanged(object sender, EventArgs e)
        {
            BuyBySku(barCodeBox.Text);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);

            settingsForm.Show();
        }

        private void barCodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            String barCodeStr = barCodeBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                BuyBySku(barCodeStr);
                barCodeBox.Text = "";
            }
        }

        private void setBarcodeScanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barCodeBox.Select();
        }

        private void barCodeBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm(this);

            clientsForm.Show();
        }

        private void productsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cashierName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CashierChooseForm cashierForm = new CashierChooseForm(this);

            cashierForm.Show();
        }

        private void выбратьКассирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierChooseForm cashierForm = new CashierChooseForm(this);

            cashierForm.Show();
        }
    }
}
