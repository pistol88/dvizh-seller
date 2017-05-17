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
    public partial class CashiersBookForm : Form
    {
        CashierForm cashierForm;

        services.Database db = new services.Database();
        
        tools.CashierProvider cashiersProvider = new tools.CashierProvider();

        repositories.Cashier cashiers;

        services.DataMapper dataMapper;

        entities.Cashier selectedCashier = null;

        public CashiersBookForm(CashierForm setCashierForm)
        {
            InitializeComponent();

            cashierForm = setCashierForm;

            if (cashiersProvider.Count > 0)
            {
                SelectFormCashier(cashiersProvider[0]);
            }
        }

        private void SelectFormCashier(entities.Cashier cashier)
        {
            selectedCashier = cashier;
            cashierBox.Visible = true;
            cashierNameBox.Text = cashier.GetName();
        }

        private bool AddCashier()
        {
            if (addCashierNameBox.Text == "")
            {
                MessageBox.Show("Имя обязательно");

                return false;
            }

            entities.Cashier cashier = new entities.Cashier(0, addCashierNameBox.Text);

            cashiers.SaveWithSql(cashier);

            cashiersProvider.Add(cashier);

            cashiersGridView.Update();

            addCashierNameBox.Text = "";

            MessageBox.Show("Сохранено");

            return true;
        }


        private void CashiersBookForm_Load(object sender, EventArgs e)
        {
            cashiers = new repositories.Cashier(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillCashiers(cashiers);

            foreach (entities.Cashier cashier in cashiers.GetList())
            {
                cashiersProvider.Add(cashier);
            }


            if (cashiersProvider.Count > 0)
            {
                SelectFormCashier(cashiersProvider[0]);
            }

            cashiersGridView.DataSource = cashiersProvider;

            cashiersGridView.Update();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedCashier != null)
            {
                selectedCashier.SetName(cashierNameBox.Text);
                
                cashiers.SaveWithSql(selectedCashier);

                MessageBox.Show("Сохранено");
            }

            cashiersGridView.Update();
            cashiersGridView.Focus();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedCashier != null)
            {
                cashiers.DeleteWithSql(selectedCashier);

                cashiersProvider.Remove(selectedCashier);

                cashierBox.Visible = false;
            }

            cashiersGridView.Update();
            cashiersGridView.Focus();
        }

        private void addCashierButton_Click(object sender, EventArgs e)
        {
            AddCashier();
        }

        private void cashiersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectFormCashier(cashiersProvider[cashiersGridView.CurrentCell.RowIndex]);
        }

        private void CashiersBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cashierForm.ReRenderAllCashiers();
        }
    }
}
