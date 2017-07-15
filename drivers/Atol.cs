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
        private byte taxNumber = 1;
        bool driverExists = true;

        FprnM1C.IFprnM45 cmd;

        dynamic driver = false;

        public const int DOC_TYPE_SERVICE = 0; //For print texts
        public const int DOC_TYPE_REGISTER = 1; //For fiscal registration
        public const int DOC_TYPE_ANNULATE = 2;

        public Atol()
        {
            statuses = new List<int>();

            try
            {
                driver = Type.GetTypeFromProgID("AddIn.FPrnM45");

                if (driver != null)
                    cmd = Activator.CreateInstance(driver);
                else
                {
                    driverExists = false;
                    return;
                }

                driverExists = true;

                if (cmd.CheckState != 0)
                    cmd.CancelCheck();
                
                cmd.AttrPrint = 1;

                cmd.DeviceEnabled = true;
                cmd.Password = "30";

                if (cmd.GetStatus() < 0)
                    MessageBox.Show("Ошибка ККТ: " + cmd.GetStatus().ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удалось загрузить драйвер Атол.");
                driverExists = false;
            }
        }

        public bool Ready()
        {
            return driverExists;
        }

        public void OpenDocument(byte type)
        {
            if (!driverExists)
                return;

            if (type > 2)
                type = DOC_TYPE_ANNULATE;
            else
                type = DOC_TYPE_REGISTER;

            cmd.OperatorName = cashierName;

            cmd.Mode = 1;
            cmd.SetMode();

            cmd.TestMode = Properties.Settings.Default.testMode;
            cmd.CheckType = type;

            cmd.OpenCheck();

            if (cmd.Fiscal)
                cmd.BeginFiscDocument();
            else
                cmd.BeginDocument();
        }

        public void CloseDocument()
        {
            if (!driverExists)
                return;

            cmd.CloseCheck();

            if (cmd.Fiscal)
                cmd.EndFiscDocument();
            else
                cmd.EndDocument();
        }

        public List<int> GetStatuses()
        {
            return statuses;
        }

        public void SetTaxNumber(byte number)
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
            //none
        }

        public void PrintString(string text)
        {
            if (!driverExists)
                return;
            
            cmd.Mode = 1;
            cmd.SetMode();
            cmd.Alignment = 1;
            cmd.Caption = text;
            cmd.PrintString();
        }

        public void RegisterProduct(string name, string barcode, double quantity, double price, int numPos = 1)
        {
            if (!driverExists)
                return;

            if (cmd.GetStatus() < 0)
            {
                MessageBox.Show("Ошибка ККМ: " + cmd.GetStatus().ToString());
                return;
            }

            cmd.Name = name;
            cmd.Price = price;
            cmd.Quantity = quantity;
            cmd.Department = numPos;
            
            cmd.Registration();
        }

        public void AnnulateProduct(string name, double quantity, double price)
        {
            if (!driverExists)
                return;

            if (cmd.GetStatus() < 0) {
                MessageBox.Show("Ошибка ККМ: " + cmd.GetStatus().ToString());
                return;
            }
                
            cmd.Alignment = 1;
            cmd.Caption = "Отмена операции";
            cmd.PrintString();

            cmd.Name = name;
            cmd.Price = price;
            cmd.Quantity = quantity;

            cmd.Caption = name + " - отменен";
            cmd.PrintString();

            cmd.BuyReturn();
            
            cmd.Registration();
        }

        public void RegisterPayment(double sum, byte type = 0)
        {
            if (!driverExists)
                return;

            cmd.Mode = 1;
            cmd.SetMode();
            cmd.TypeClose = type;
            cmd.Summ = sum;
            cmd.Payment();
        }

        public void PrintTotal()
        {
            if (!driverExists)
                return;
            
            cmd.CashIncome();
        }

        public void RegisterDiscount(byte type, string nameDiscount, int sum)
        {
            cmd.DiscountType = type;
            cmd.DiscountValue = sum;
        }

        public void PrintServiceData()
        {
            if (!driverExists)
                return;
            
            cmd.Alignment = 1;
            cmd.Caption = "Тестирование печати.";
            cmd.PrintString();
            
            cmd.Caption = "Все ОК.";
            cmd.PrintString();
            
            cmd.Caption = "Номер чека: " + cmd.CheckNumber.ToString();
            cmd.PrintString();
            
            cmd.Caption = cmd.DeviceSettings;
            cmd.PrintString();
            
            if (cmd.Fiscal)
                cmd.Caption = "Фискальный";
            else
                cmd.Caption = "Нефискальный";
            cmd.PrintString();
            
            cmd.Caption = "ИНН" + cmd.INN;
            cmd.PrintString();
        }

        public void OpenSession()
        {
            if (!driverExists)
                return;

            if (cmd.GetStatus() < 0)
                return;

            cmd.Mode = 1;
            cmd.SetMode();
            cmd.OpenSession();
            cmd.Beep();
        }

        public void CloseSession()
        {
            if (!driverExists)
                return;

            if (cmd.CheckState != 0)
                cmd.CancelCheck();

            if (cmd.GetStatus() < 0)
                return;

            cmd.Mode = 3;
            cmd.SetMode();
            cmd.ReportType = 1;
            cmd.Report();
            cmd.Beep();
        }

        public bool IsSessionOpen()
        {
            if(cmd.SessionExceedLimit)
            {
                MessageBox.Show("Смена превысила 24 часа, нужно перезапустить ее.");
            }

            if (cmd.GetStatus() < 0)
                return false;

            if (!driverExists)
                return false;
             
            cmd.Mode = 1;
            cmd.SetMode();

            bool opened = cmd.SessionOpened;
            
            return opened;
        }

        ~Atol()
        {
            cmd.DeviceEnabled = false;
        }
    }
}
