using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.drivers
{
    public interface FiscalInterface
    {
        void OpenDocument(byte type);

        void CloseDocument();

        void SetTaxNumber(byte number);

        void SetCashierName(string name);

        void SetNumDepart(byte number);

        void SetDocNumber(int number);

        void ScrollPaper();

        void PrintString(string text);

        void RegisterProduct(string name, string barcode, double quantity, double price, int numPos = 1);

        void RegisterPayment(double sum, byte type = 0);

        void RegisterDiscount(byte type, string nameDiscount, int sum);

        void PrintTotal();
        
        void PrintServiceData();

        bool Ready();

        bool IsSessionOpen();

        void OpenSession();

        void AnnulateProduct(string name, double quantity, double price);

        void CloseSession();

        List<int> GetStatuses();
    }
}
