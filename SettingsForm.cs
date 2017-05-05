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
    public partial class SettingsForm : Form
    {
        Cashier cashierForm;

        repositories.Cashbox cashboxes = new repositories.Cashbox();

        services.DataMapper dataMapper;

        public SettingsForm(Cashier setCashierForm)
        {
            cashierForm = setCashierForm;

            dataMapper = new services.DataMapper();
            dataMapper.FillCashboxes(cashboxes);

            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            protocolBox.Text = Properties.Settings.Default.protocol;
            hostBox.Text = Properties.Settings.Default.host;
            clientBox.Text = Properties.Settings.Default.client;
            currencyBox.Text = Properties.Settings.Default.currency;
            tokenBox.Text = Properties.Settings.Default.token;
            online.Checked = Properties.Settings.Default.online;
            fiscal.Checked = Properties.Settings.Default.online;
            barcodescaner.Checked = Properties.Settings.Default.barcodescaner;
            checkNoteBox.Text = Properties.Settings.Default.checkNote;

            foreach (entities.Cashbox cashbox in cashboxes.GetList())
            {
                Item item = new Item(cashbox.GetName(), cashbox.GetId());

                cashboxId.Items.Add(item);

                if(cashbox.GetId() == Properties.Settings.Default.cashboxId)
                {
                    cashboxId.SelectedItem = item;
                }
            }
        }

        private void settingsSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.protocol = protocolBox.Text;
            Properties.Settings.Default.host = hostBox.Text;
            Properties.Settings.Default.client = clientBox.Text;
            Properties.Settings.Default.currency = currencyBox.Text;
            Properties.Settings.Default.token = tokenBox.Text;
            Properties.Settings.Default.online = online.Checked;
            Properties.Settings.Default.online = fiscal.Checked;
            Properties.Settings.Default.barcodescaner = barcodescaner.Checked;
            Properties.Settings.Default.checkNote = checkNoteBox.Text;

            object selectedItem = cashboxId.SelectedItem;
            Properties.Settings.Default.cashboxId = Convert.ToInt32(selectedItem.GetHashCode());

            if (fiscal.Checked)
                cashierForm.ActivateFiscal();
            else
                cashierForm.DeactivateFiscal();

            Properties.Settings.Default.Save();

            MessageBox.Show("Сохранено");
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
    }
}
