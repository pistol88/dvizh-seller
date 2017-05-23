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
    public partial class FreeSaleForm : Form
    {
        public CashierForm cashierForm;

        public FreeSaleForm(CashierForm setCashierForm)
        {
            cashierForm = setCashierForm;
            InitializeComponent();
        }

        private void FreeSaleForm_Load(object sender, EventArgs e)
        {
            priceBox.Select();
            priceBox.Focus();
        }

        private void FreeSaleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string productName = nameBox.Text;
                double productPrice = Convert.ToDouble(priceBox.Text);
                int count = Convert.ToInt16(productCount.Value);
                entities.Product product = new entities.Product(0, "0", productName, productPrice);

                cashierForm.PutToCart(product, count);
                productCount.Value = 1;
                nameBox.Text = "Товар X";
                priceBox.Text = "";


                cashierForm.BarCodeFocus();

                this.Close();
            }
        }
    }
}
