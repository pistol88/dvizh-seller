using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.drivers
{
    interface FiscalInterface
    {
        void OpenDocument(int type);

        void CloseDocument();

        void SetTaxNumber(sbyte number);

        void SetCashierName(string name);

        void SetNumDepart(byte number);

        void SetDocNumber(int number);

        void ScrollPaper();

        void PrintString(string text);

        void RegisterProduct(string name, string barcode, double quantity, double price, int numPos = 1);

        void PrintPayment(double sum);

        void PrintTotal();

        void PrintDiscount();
        
        void PrintServiceData();

        List<int> GetStatuses();
    }
}
