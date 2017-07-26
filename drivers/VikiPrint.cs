using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DvizhSeller.drivers
{
    public class VikiPrint : PiritLib, FiscalInterface
    {
        private string cashierName = "Unknow";
        private int docNumber = 1;
        private byte numDepart = 1;
        private List<int> statuses;
        private byte taxNumber = 1;
        string portName;
        int portSpeed;

        public const int DOC_TYPE_SERVICE = 1; //For print texts
        public const int DOC_TYPE_REGISTER = 2; //For fiscal registration
        public const int DOC_TYPE_RETURN = 3;
        public const int DOC_TYPE_INCOME = 4;
        public const int DOC_TYPE_OUTCOME = 5;
        public const int DOC_TYPE_BUY = 6;
        public const int DOC_TYPE_ANNULATE = 7;

        public VikiPrint(string setPortName, int setPortSpeed)
        {
            portName = setPortName;
            portSpeed = setPortSpeed;

            taxNumber = Convert.ToByte(Properties.Settings.Default.taxType);

            int result = openPort(portName, portSpeed);

            //commandStart();

            statuses = new List<int>();
        }

        public bool Ready()
        {
            int fatalStatus, currentFlagsStatus, documentStatus;
            int flagsStatus = getStatusFlags(out fatalStatus, out currentFlagsStatus, out documentStatus);

            if (flagsStatus == 0)
                return true;
            else
                return false;
        }

        public void OpenDocument(byte type)
        {
            libOpenDocument(type, numDepart, cashierName, docNumber);
        }

        public void CloseDocument()
        {
            MData test = new MData();
            libCloseDocument(ref test, 1);
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
            cashierName = ConvertTo866(name);
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
            scrollPaper();
        }

        public void PrintString(string text)
        {
            libPrintString(text, null);

            MData test = new MData();
            libCloseDocument(ref test, 1);
        }

        public void RegisterProduct(string name, string barcode, double quantity, double price, int numPos = 1)
        {
            libAddPosition(ConvertTo866(name), ConvertTo866(barcode), quantity, price, taxNumber, numPos, numDepart, 0, "", 0);
        }

        public void AnnulateProduct(string name, double quantity, double price)
        {
            int numPos = 1;
            libAddPosition(ConvertTo866(name), ConvertTo866(name), quantity, price, taxNumber, numPos, numDepart, 0, "", 0);
        }

        public void RegisterPayment(double sum, byte type = 0)
        {
            int result = libAddPaymentD(type, sum, "");
        }

        public void PrintTotal()
        {
            libSubTotal();
        }

        public void RegisterDiscount(byte type, string nameDiscount, int sum)
        {
            libAddDiscount(type, nameDiscount, sum);
        }
        
        public void PrintServiceData()
        {
            libPrintServiceData();
        }

        public void OpenSession()
        {
            libOpenShift(cashierName);
        }

        public void CloseSession()
        {
            libPrintZReport(cashierName, 0);
        }

        public bool IsSessionOpen()
        {
            int fatalStatus, currentFlagsStatus, documentStatus;
            int flagsStatus = getStatusFlags(out fatalStatus, out currentFlagsStatus, out documentStatus);

            //MessageBox.Show(flagsStatus.ToString() + '-' + fatalStatus.ToString() + '-' + currentFlagsStatus.ToString() + '-' + documentStatus.ToString());

            if (flagsStatus == 0)
            {
                if (currentFlagsStatus == 12)
                {
                    MessageBox.Show("Смена длится более 24 часов. Перезапустите смену.");
                    return true;
                }

                if (currentFlagsStatus == 4)
                    return true;
                else
                    return false;
            }

            return false;
        }

        private string ConvertTo866(string str)
        {
            return System.Text.Encoding.Default.GetString(Encoding.Convert(Encoding.GetEncoding("windows-1251"), Encoding.GetEncoding("CP866"), Encoding.GetEncoding("windows-1251").GetBytes(str)));
        }

        ~VikiPrint()
        {
            closePort();
        }
    }
}
