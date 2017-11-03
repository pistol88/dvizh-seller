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
        CashierForm cashierForm;

        services.Database db = new services.Database();

        int loadedFiscalType;

        repositories.Cashbox cashboxes;

        services.DataMapper dataMapper;

        public SettingsForm(CashierForm setCashierForm)
        {
            cashierForm = setCashierForm;

            cashboxes = new repositories.Cashbox(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillCashboxes(cashboxes);

            InitializeComponent();
        }

        private void renderFiscalSettings()
        {
            if(fiscal.Checked)
                fiscalSettings.Enabled = true;
            else
                fiscalSettings.Enabled = false;

            if (fiscalDriverTypeBox.SelectedIndex == 0)
            {
                fiscalComPortBox.Enabled = true;
                atolSettingsButton.Enabled = false;
            }

            if (fiscalDriverTypeBox.SelectedIndex == 1)
            {
                fiscalComPortBox.Enabled = false;
                atolSettingsButton.Enabled = true;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            protocolBox.Text = Properties.Settings.Default.protocol;
            hostBox.Text = Properties.Settings.Default.host;
            dbFileBox.Text = Properties.Settings.Default.dbFile;
            clientBox.Text = Properties.Settings.Default.client;
            currencyBox.Text = Properties.Settings.Default.currency;
            tokenBox.Text = Properties.Settings.Default.token;
            online.Checked = Properties.Settings.Default.online;
            fiscal.Checked = Properties.Settings.Default.fiscal;
            testMode.Checked = Properties.Settings.Default.testMode;
            barcodescaner.Checked = Properties.Settings.Default.barcodescaner;
            checkNoteBox.Text = Properties.Settings.Default.checkNote;
            roundingTypeBox.SelectedIndex = Properties.Settings.Default.roundingType;
            roundingBox.Text = Properties.Settings.Default.rounding.ToString();
            fiscalComPortBox.Text = Properties.Settings.Default.fiscalComPort.ToString();
            autoOpenTabletBox.Checked = Properties.Settings.Default.autoOpenTablet;
            autoStartWebServerBox.Checked = Properties.Settings.Default.autoStartWebServer;
            taxBox.Text = Properties.Settings.Default.taxType.ToString();

            Item vikiItem = new Item("VikiPrint (Пирит)", 1);
            fiscalDriverTypeBox.Items.Add(vikiItem);

            Item atolItem = new Item("АТОЛ", 2);
            fiscalDriverTypeBox.Items.Add(atolItem);

            foreach (entities.Cashbox cashbox in cashboxes.GetList())
            {
                Item item = new Item(cashbox.GetName(), cashbox.GetId());

                cashboxId.Items.Add(item);

                if(cashbox.GetId() == Properties.Settings.Default.cashboxId)
                {
                    cashboxId.SelectedItem = item;
                }
            }

            if (Properties.Settings.Default.fiscalDriverType == 0)
                fiscalDriverTypeBox.SelectedItem = vikiItem;
            else
                fiscalDriverTypeBox.SelectedItem = atolItem;

            loadedFiscalType = fiscalDriverTypeBox.SelectedIndex;

            renderFiscalSettings();
        }

        private void settingsSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.protocol = protocolBox.Text;
            Properties.Settings.Default.host = hostBox.Text;
            Properties.Settings.Default.client = clientBox.Text;
            Properties.Settings.Default.currency = currencyBox.Text;
            Properties.Settings.Default.token = tokenBox.Text;
            Properties.Settings.Default.online = online.Checked;
            Properties.Settings.Default.fiscal = fiscal.Checked;
            Properties.Settings.Default.testMode = testMode.Checked;
            Properties.Settings.Default.barcodescaner = barcodescaner.Checked;
            Properties.Settings.Default.checkNote = checkNoteBox.Text;
            Properties.Settings.Default.roundingType = roundingTypeBox.SelectedIndex;
            Properties.Settings.Default.rounding = Convert.ToInt16(roundingBox.Text);
            Properties.Settings.Default.dbFile = dbFileBox.Text;
            Properties.Settings.Default.fiscalComPort = fiscalComPortBox.Text;
            Properties.Settings.Default.fiscalDriverType = fiscalDriverTypeBox.SelectedIndex;
            Properties.Settings.Default.autoOpenTablet = autoOpenTabletBox.Checked;
            Properties.Settings.Default.autoStartWebServer = autoStartWebServerBox.Checked;
            Properties.Settings.Default.taxType = Convert.ToInt16(taxBox.Text);

            object selectedItem = cashboxId.SelectedItem;
            Properties.Settings.Default.cashboxId = Convert.ToInt32(selectedItem.GetHashCode());

            if (fiscal.Checked)
                cashierForm.ActivateFiscal();
            else
                cashierForm.DeactivateFiscal();

            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.fiscalDriverType != loadedFiscalType)
                MessageBox.Show("Перезапустите программу, чтобы сменить драйвер.");

            savingInfo.Text = "Сохранено.";
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

        private void fiscal_CheckedChanged(object sender, EventArgs e)
        {
            renderFiscalSettings();
        }

        private void fiscalDriverTypeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            renderFiscalSettings();
        }

        private void atolSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                FprnM1C.IFprnM45 cmd = new FprnM1C.FprnM45();
                cmd.ShowProperties();
            }
            catch (Exception)
            {
                MessageBox.Show("Драйвер не установлен или поврежден. Скачайте и установите драйвера оборудования с сайта dvizh.net!");
            }
        }
    }
}
