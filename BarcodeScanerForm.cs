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
    public partial class BarcodeScanerForm : Form
    {
        CashierForm cashierForm;

        public BarcodeScanerForm(CashierForm setCashierForm)
        {
            cashierForm = setCashierForm;

            InitializeComponent();
        }

        private void BarcodeScanerForm_Load(object sender, EventArgs e)
        {
            barCodeBox.Select();
        }

        private void barCodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            String barCodeStr = barCodeBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                cashierForm.BuyBySku(barCodeStr);
                barCodeBox.Text = "";
            }
        }
    }
}
