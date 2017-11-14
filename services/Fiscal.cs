using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DvizhSeller.services
{
    public class Fiscal
    {
        repositories.Cart cart;
        drivers.FiscalInterface driver;
        byte tax_id;

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
            tax_id = 0;
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

        public void Storning(entities.OrderElement orderElement)
        {
            driver.OpenDocument(DOC_TYPE_OUTCOME);
            driver.Storning(orderElement.GetProductName(), orderElement.GetCount(), orderElement.GetPrice());
            driver.PrintTotal();
            driver.CloseDocument();
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
            
            driver.OpenDocument(DOC_TYPE_BUY);
            int i = 1;
            double cartSum = cart.GetTotal();
            double sum = 0;
            if (cart.GetDiscount() >= 1) driver.RegisterDiscount(cart.GetDiscType(), "-", cart.GetDiscount()); ;
            foreach (entities.Product element in cart.GetElements())
            {
                driver.RegisterProduct(element.GetName(), element.GetSku(), element.GetCartCount(), element.GetPrice(), i);
                sum += (element.GetCartCount()*element.GetPrice());
                i++;
            }
            double paymentSum;
            if (cartSum < sum)
            {
                int discount = Convert.ToInt32(sum - cartSum);
                if (discount <= 1)
                    discount = 1;

                paymentSum = sum-discount;
            }
            else
            {
                paymentSum = sum;
            }
            driver.SetTaxNumber(tax_id);
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

        public void SetTax(byte setTax_id)
        {
            tax_id = setTax_id;
        }
    }
}
