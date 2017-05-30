using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DvizhSeller.drivers
{
    public class VikiPrint : PiritLib, FiscalInterface
    {
        private string cashierName = "Unknow";
        private int docNumber = 1;
        private byte numDepart = 1;
        private List<int> statuses;
        private sbyte taxNumber = 1;
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

            openPort(portName, portSpeed);

            statuses = new List<int>();
        }

        public void OpenDocument(int type)
        {
            statuses.Add(libOpenDocument(1, numDepart, cashierName, docNumber));
        }

        public void CloseDocument()
        {
            MData test = new MData();
            libCloseDocument(ref test, 1);
            statuses.Add(test.errCode);
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
            scrollPaper();
        }

        public void PrintString(string text)
        {
            statuses.Add(libPrintString(text, null));

            MData test = new MData();
            libCloseDocument(ref test, 1);

            statuses.Add(test.errCode);
        }

        public void RegisterProduct(string name, string barcode, double quantity, double price, int numPos = 1)
        {
            statuses.Add(libOpenDocument(2, numDepart, cashierName, docNumber));
            statuses.Add(libAddPosition(name, barcode, quantity, price, 1, numPos, 1, 1, "", 0));
            PrintPayment(1);
        }

        public void PrintPayment(double sum)
        {
            statuses.Add(libAddPaymentD(0, sum, ""));
        }

        public void PrintTotal()
        {
            statuses.Add(libSubTotal());
        }

        public void PrintDiscount()
        {
            libAddDiscount(0, "%", 10);
        }
        
        public void PrintServiceData()
        {
            statuses.Add(libPrintServiceData());
        }

        ~VikiPrint()
        {
            closePort();
        }
    }
}
