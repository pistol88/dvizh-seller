using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DvizhSeller.services
{
    class Fiscal
    {
        repositories.Cart cart;
        public List<entities.Product> lastElements;
        FprnM1C.IFprnM45 cmd;
        bool driverExists;
        drivers.FiscalInterface driver;

        public Fiscal(drivers.FiscalAbstractFabricInterface fiscalFabric, repositories.Cart setCart = null)
        {
            driver = fiscalFabric.Build();
            cart = setCart;
        }

        public bool Ready()
        {
            return true;
        }

        public void PrintString(string str)
        {
            driver.PrintString(str);
        }

        public void TestPrint()
        {
            driver.PrintServiceData();
        }

        public void March()
        {
            //))))
        }

        public void Annulate(entities.OrderElement orderElement)
        {
            //
        }

        public void Register(string cashierName, int paymentType = 0, bool discount = false, int discountType = 1, int discountVal = 0)
        {
            if (cart.GetCount() <= 0)
                return;

            driver.SetCashierName(cashierName);
            driver.OpenDocument(2);
            int i = 1;
            double sum = 0;
            foreach (entities.Product element in cart.GetElements())
            {
                driver.RegisterProduct(element.GetName(), element.GetSku(), element.GetCartCount(), element.GetPrice(), i);
                //lastElements.Add(element);
                sum = sum + (element.GetPrice()*element.GetCartCount());
                i++;
            }

            driver.PrintPayment(sum);
            driver.CloseDocument();
        }

        public void OpenShift()
        {
            
        }

        public void CloseShift()
        {
            
        }

        public bool SessionOpened()
        {
            return true;
        }

        public List<int> GetStatus()
        {
            return driver.GetStatuses();
        }
    }
}
