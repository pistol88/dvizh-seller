using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DvizhSeller.drivers
{
    public class Atol : FiscalInterface
    {
        private string cashierName = "Unknow";
        private int docNumber = 1;
        private byte numDepart = 1;
        private List<int> statuses;
        private sbyte taxNumber = 1;
        bool driverExists = false;

        FprnM1C.IFprnM45 cmd;

        public const int DOC_TYPE_SERVICE = 1; //For print texts
        public const int DOC_TYPE_REGISTER = 2; //For fiscal registration
        public const int DOC_TYPE_RETURN = 3;
        public const int DOC_TYPE_INCOME = 4;
        public const int DOC_TYPE_OUTCOME = 5;
        public const int DOC_TYPE_BUY = 6;
        public const int DOC_TYPE_ANNULATE = 7;

        public Atol()
        {
            statuses = new List<int>();

            try
            {
                cmd = new FprnM1C.FprnM45();

                driverExists = true;

                if (cmd.CheckState != 0)
                    cmd.CancelCheck();

                cmd.Password = "30";
            }
            catch (Exception e)
            {
                MessageBox.Show("Драйвер Атол не удалось загрузить.");
                driverExists = false;
            }
        }

        public void OpenDocument(byte type)
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";

            cmd.Mode = 1;
            cmd.SetMode();

            cmd.TestMode = Properties.Settings.Default.testMode;
            cmd.CheckType = 1;

            cmd.OpenCheck();

            if (cmd.Fiscal)
                cmd.BeginFiscDocument();
            else
                cmd.BeginDocument();
        }

        public void CloseDocument()
        {
            cmd.CloseCheck();

            if (cmd.Fiscal)
                cmd.EndFiscDocument();
            else
                cmd.EndDocument();

            cmd.DeviceEnabled = false;
        }

        public List<int> GetStatuses()
        {
            return statuses;
        }

        public void SetTaxNumber(sbyte number)
        {
            taxNumber = number;
        }

        public void SetCashierName(string name)
        {
            cashierName = name;
        }

        public void SetNumDepart(byte number)
        {
            numDepart = number;
        }

        public void SetDocNumber(int number)
        {
            docNumber = number;
        }

        public void ScrollPaper()
        {
            
        }

        public void PrintString(string text)
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";
            cmd.Mode = 1;
            cmd.SetMode();
            cmd.Alignment = 1;
            cmd.Caption = text;
            cmd.PrintString();
            cmd.DeviceEnabled = false;
        }

        public void RegisterProduct(string name, string barcode, double quantity, double price, int numPos = 1)
        {
            cmd.Name = name;
            cmd.Price = price;
            cmd.Quantity = quantity;
            cmd.Department = numDepart;
            
            cmd.Registration();
        }

        public void RegisterPayment(double sum)
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";
            cmd.Mode = 1;
            cmd.SetMode();
            cmd.Summ = sum;
            cmd.Payment();
            cmd.DeviceEnabled = false;
        }

        public void PrintTotal()
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";
            cmd.CashIncome();
            cmd.DeviceEnabled = false;
        }

        public void RegisterDiscount(byte type, string nameDiscount, int sum)
        {
            return;
        }

        public void PrintServiceData()
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";
            cmd.Alignment = 1;
            cmd.Caption = "Тестирование печати.";
            cmd.PrintString();

            cmd.Alignment = 1;
            cmd.Caption = "Все ОК.";
            cmd.PrintString();

            cmd.Alignment = 1;
            //cmd.Caption = cmd.UModel.ToString() + " - " + cmd.Model.ToString() + " - " + cmd.ROMVersion;
            cmd.PrintString();

            cmd.Alignment = 1;
            cmd.Caption = "Номер чека: " + cmd.CheckNumber.ToString();
            cmd.PrintString();

            cmd.Alignment = 1;
            cmd.Caption = cmd.DeviceSettings;
            cmd.PrintString();

            cmd.Alignment = 1;
            if (cmd.Fiscal)
                cmd.Caption = "Фискальный";
            else
                cmd.Caption = "Нефискальный";
            cmd.PrintString();
            
            cmd.Alignment = 1;
            cmd.Caption = "ИНН" + cmd.INN;
            cmd.PrintString();
            cmd.DeviceEnabled = false;
        }

        public void OpenShift()
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";
            cmd.Mode = 1;
            cmd.SetMode();
            cmd.OpenSession();
            cmd.Beep();
            cmd.DeviceEnabled = false;
        }

        public void CloseShift()
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";
            cmd.Mode = 3;
            cmd.SetMode();
            cmd.ReportType = 1;
            cmd.Report();
            cmd.Beep();
            cmd.DeviceEnabled = false;
        }

        public bool IsSessionOpen()
        {
            cmd.DeviceEnabled = true;
            cmd.Password = "30";
            cmd.Mode = 1;
            cmd.SetMode();

            bool opened = cmd.SessionOpened;

            cmd.DeviceEnabled = false;

            return opened;
        }

        ~Atol()
        {
            
        }
    }
}
