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
    public partial class CashierChooseForm : Form
    {
        repositories.Cashier cashiers = new repositories.Cashier();
        services.DataMapper dataMapper;

        CashierForm cashierForm;

        public CashierChooseForm(CashierForm setCashierForm)
        {
            cashierForm = setCashierForm;

            dataMapper = new services.DataMapper();
            dataMapper.FillCashiers(cashiers);

            InitializeComponent();
        }

        private void CashierChooseForm_Load(object sender, EventArgs e)
        {
            foreach(entities.Cashier cashier in cashiers.GetList())
            {
                Item item = new Item(cashier.GetName(), cashier.GetId());

                cashiersList.Items.Add(item);

                cashiersList.SelectedItem = item;
            }
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

            public override int GetHashCode()
            {
                return Value;
            }
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            cashierForm.ChooseCashier(cashiersList.SelectedItem.GetHashCode(), cashiersList.SelectedItem.ToString());

            this.Close();
        }
    }
}
