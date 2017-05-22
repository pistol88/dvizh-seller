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
    public partial class ShopBookForm : Form
    {
        services.Database db = new services.Database();

        tools.ProductProvider productsProvider = new tools.ProductProvider();
        tools.ProductProvider searchProductsProvider = new tools.ProductProvider();
        tools.CategoryProvider categoriesProvider = new tools.CategoryProvider();

        entities.Product selectedProduct = null;

        repositories.Product products;
        repositories.Category categories;

        services.DataMapper dataMapper;

        CashierForm cashierForm;

        public ShopBookForm(CashierForm setCashierForm)
        {
            cashierForm = setCashierForm;

            InitializeComponent();

            SetProductsList();

            foreach (entities.Product product in products.GetList())
            {
                productsProvider.Add(product);
            }

            foreach (entities.Category category in categories.GetList())
            {
                categoriesProvider.Add(category);
            }

            if(productsProvider.Count > 0)
            {
                SelectFormProduct(productsProvider[0]);
            }

            productsGridView.DataSource = productsProvider;
            
            productsGridView.Update();
        }

        public void SetProductsList()
        {
            products = new repositories.Product(db);
            categories = new repositories.Category(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillCategories(categories);
            dataMapper.FillProducts(products, categories);
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (searchBox.Text == "")
                    productsGridView.DataSource = productsProvider;
                else
                {
                    searchProductsProvider = new tools.ProductProvider();

                    foreach (entities.Product product in products.FindByString(searchBox.Text))
                    {
                        searchProductsProvider.Add(product);
                    }

                    productsGridView.DataSource = searchProductsProvider;
                }
            }
        }
        
        private void searchBox_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "Название или штрихкод")
            {
                searchBox.Text = "";
            }
        }

        private void SelectFormProduct(entities.Product product)
        {
            productsTabControl.Visible = true;
            selectedProduct = product;
            productNameBox.Text = product.GetName();
            productPriceBox.Text = product.GetPrice().ToString();
            productSkuBox.Text = product.GetSku();

            productPrice.Text = product.GetPrice().ToString() + Properties.Settings.Default.currency;
            productSku.Text = product.GetSku();
            productCount.Value = 1;
            productAmount.Text = product.GetAmount().ToString();
            productPicture.ImageLocation = product.GetImage();
        }

        private void productsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectFormProduct(productsProvider[productsGridView.CurrentCell.RowIndex]);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(selectedProduct != null)
            {
                selectedProduct.SetName(productNameBox.Text);
                selectedProduct.SetPrice(Convert.ToDouble(productPriceBox.Text));
                selectedProduct.SetSku(productSkuBox.Text);

                products.SaveWithSql(selectedProduct);

                MessageBox.Show("Сохранено");
            }

            productsGridView.Update();
            productsGridView.Focus();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                products.DeleteWithSql(selectedProduct);

                productsProvider.Remove(selectedProduct);
            }

            productsGridView.Update();
            productsGridView.Focus();

            productsTabControl.Visible = false;
        }

        private bool AddProduct()
        {
            if (addProductNameBox.Text == "")
            {
                MessageBox.Show("Имя обязательно");

                return false;
            }

            if (addProductPriceBox.Text == "")
            {
                MessageBox.Show("Цена обязательна");

                return false;
            }

            entities.Product product = new entities.Product(0, addProductSkuBox.Text, addProductNameBox.Text, Convert.ToDouble(addProductPriceBox.Text));

            products.SaveWithSql(product);

            productsProvider.Add(product);

            productsGridView.Update();

            addProductNameBox.Text = "";
            addProductSkuBox.Text = "";
            addProductPriceBox.Text = "";

            SetProductsList();

            MessageBox.Show("Сохранено");

            return true;
        }

        private void PutToCart()
        {
            cashierForm.PutToCart(selectedProduct, Convert.ToInt32(productCount.Value));
            productCount.Value = 1;
        }

        private void addProdutButton_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            PutToCart();
        }

        private void ShopBookForm_Load(object sender, EventArgs e)
        {

        }

        private void ShopBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cashierForm.SetProductsList();
        }
    }
}
