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
    public partial class TabletForm : Form
    {
        CashierForm cashierForm;

        public TabletForm(CashierForm setCashierForm)
        {
            cashierForm = setCashierForm;
            InitializeComponent();
        }

        private void TabletForm_Load(object sender, EventArgs e)
        {
             
        }
    }
}
