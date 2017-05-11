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

        repositories.Product products;
        repositories.Category categories;

        services.DataMapper dataMapper;

        public ShopBookForm()
        {
            InitializeComponent();

            products = new repositories.Product(db);
            categories = new repositories.Category(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillCategories(categories);
            dataMapper.FillProducts(products, categories);

            foreach (entities.Product product in products.GetList())
            {
                productsProvider.Add(product);
            }

            foreach (entities.Category category in categories.GetList())
            {
                categoriesProvider.Add(category);
            }

            productsGridView.DataSource = productsProvider;


            productsGridView.Update();
        }

        private void ShopBook_Load(object sender, EventArgs e)
        {

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
    }
}
