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
    public partial class DiscountsBookForm : Form
    {
        services.Database db = new services.Database();

        tools.DisountProvider discountsProvider = new tools.DisountProvider();
        tools.DisountProvider searchDiscountsProvider = new tools.DisountProvider();

        repositories.Discount discounts;

        services.DataMapper dataMapper;

        public DiscountsBookForm()
        {
            InitializeComponent();

            discounts = new repositories.Discount(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillDiscounts(discounts);

            foreach (entities.Discount discount in discounts.GetList())
            {
                discountsProvider.Add(discount);
            }

            discountsGridView.DataSource = discountsProvider;
        }

        private void DiscountsBookForm_Load(object sender, EventArgs e)
        {
            discountsGridView.Update();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (searchBox.Text == "")
                    discountsGridView.DataSource = discountsProvider;
                else
                    searchDiscountsProvider = new tools.DisountProvider();

                foreach (entities.Discount discount in discounts.FindByCode(searchBox.Text))
                {
                    searchDiscountsProvider.Add(discount);
                }

                discountsGridView.DataSource = searchDiscountsProvider;
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "Код")
            {
                searchBox.Text = "";
            }
        }
    }
}
