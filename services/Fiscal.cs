using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DvizhSeller.services
{
    public class Fiscal
    {
        repositories.Cart cart;
        drivers.FiscalInterface driver;

        public const int DOC_TYPE_SERVICE = 1; //For print texts
        public const int DOC_TYPE_REGISTER = 2; //For fiscal registration
        public const int DOC_TYPE_RETURN = 3;
        public const int DOC_TYPE_INCOME = 4;
        public const int DOC_TYPE_OUTCOME = 5;
        public const int DOC_TYPE_BUY = 6;
        public const int DOC_TYPE_ANNULATE = 7;

        public Fiscal(drivers.FiscalAbstractFabricInterface fiscalFabric, repositories.Cart setCart = null)
        {
            driver = fiscalFabric.Build();
            cart = setCart;
        }

        public bool Ready()
        {
            return driver.Ready();
        }

        public void PrintString(string str)
        {
            driver.OpenDocument(DOC_TYPE_SERVICE);
            driver.PrintString(str);
            driver.CloseDocument();
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
            driver.OpenDocument(DOC_TYPE_ANNULATE);
            driver.AnnulateProduct(orderElement.GetProductName(), orderElement.GetCount(), orderElement.GetPrice());
            driver.PrintTotal();
            driver.RegisterPayment(orderElement.GetPrice(), 0);
            driver.CloseDocument();
        }

        public void SetCashier(string cashierName)
        {
            driver.SetCashierName(cashierName);
        }

        public void Register(byte paymentType = 0)
        {
            if (cart.GetCount() <= 0)
                return;
            
            driver.OpenDocument(DOC_TYPE_REGISTER);
            int i = 1;
            double cartSum = cart.GetTotal();
            double sum = 0;
            foreach (entities.Product element in cart.GetElements())
            {
                driver.RegisterProduct(element.GetName(), element.GetSku(), element.GetCartCount(), element.GetPrice(), i);
                sum += (element.GetCartCount()*element.GetPrice());
                i++;
            }

            double paymentSum;
            if(cartSum < sum)
            {
                int discount = Convert.ToInt32(sum - cartSum);
                if (discount <= 1)
                    discount = 1;

                driver.RegisterDiscount(1, "-", discount);
                paymentSum = sum-discount;
            }
            else
            {
                paymentSum = sum;
            }

            driver.PrintTotal();
            driver.RegisterPayment(cartSum, paymentType);
            driver.CloseDocument();
        }

        public void OpenSession()
        {
            driver.OpenSession();
        }

        public void CloseSession()
        {
            driver.CloseSession();
        }
        
        public bool IsSessionOpen()
        {
            return driver.IsSessionOpen();
        }
        
        public List<int> GetStatus()
        {
            return driver.GetStatuses();
        }
    }
}
