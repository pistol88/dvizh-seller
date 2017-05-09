using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.services
{
    class Fiscal
    {
        repositories.Cart cart;
        public List<entities.Product> lastElements;
        dynamic driver = false;
        dynamic cmd = false;

        public Fiscal(repositories.Cart setCart = null)
        {
            cart = setCart;
            lastElements = new List<entities.Product>();

            driver = Type.GetTypeFromProgID("AddIn.FPrnM45");

            if (driver != null)
            {
                cmd = Activator.CreateInstance(driver);
            }
        }

        public Boolean DriverExists()
        {
            if (driver == null)
            {
                return false;
            }

            if (driver.ToString() == "System.__ComObject")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean SessionOpened()
        {
            if (!DriverExists())
            {
                return false;
            }

            cmd.DeviceEnabled = 1;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = 30;
                cmd.Mode = 1;
                cmd.SetMode();

                return cmd.SessionOpened();
            }
        }

        public Boolean Annulate(entities.OrderElement orderElement)
        {
            if (!DriverExists())
            {
                return false;
            }

            cmd.SlipDocCharLineLength = 32;
            cmd.SlipDocTopMargin = 0;
            cmd.SlipDocLeftMargin = 1;
            cmd.SlipDocOrientation = 0;

            cmd.DeviceEnabled = 1;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = 30;
                cmd.Mode = 1;
                cmd.SetMode();
                cmd.CheckType = 2;
                cmd.OpenCheck();
                cmd.BeginDocument();
                cmd.Alignment = 1;
                cmd.Caption = "-------------------------DVIZH";
                cmd.PrintString();
                cmd.Alignment = 1;
                cmd.Caption = "Отмена операции";
                cmd.PrintString();
                cmd.TextWrap = 2;
                
                    cmd.Name = orderElement.GetProductName();
                    cmd.Price = orderElement.GetPrice();
                    cmd.Quantity = orderElement.GetCount();

                    cmd.Caption = cmd.Name + " - отменен";
                    cmd.PrintString();

                    cmd.BuyReturn();
                    //cmd.Registration();

                lastElements.Clear();

                cmd.Caption = "                              ";
                cmd.PrintString();
                cmd.Caption = "-------------------------DVIZH";
                cmd.PrintString();
                cmd.Caption = "                              ";
                cmd.PrintString();
                cmd.Caption = "                              ";
                cmd.PrintString();
                cmd.Caption = "                              ";
                cmd.PrintString();

                cmd.CloseCheck();

                cmd.EndDocument();
            }
            //cmd.Beep();
            cmd.DeviceEnabled = 0;

            return true;
        }

        public Boolean Register(string cashierName, int paymentType = 0)
        {
            if (!DriverExists())
            {
                return false;
            }

            if (cart.GetCount() == 0)
            {
                return true;
            }

            cmd.SlipDocCharLineLength = 32;
            cmd.SlipDocTopMargin = 0;
            cmd.SlipDocLeftMargin = 1;
            cmd.SlipDocOrientation = 0;

            cmd.DeviceEnabled = 1;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = 30;
                cmd.Mode = 1;
                cmd.SetMode();
                cmd.CheckType = 1;
                cmd.OpenCheck();
                cmd.BeginDocument();
                cmd.Alignment = 1;
                cmd.Caption = "-------------------------DVIZH";
                cmd.PrintString();
                cmd.Alignment = 1;
                cmd.Caption = Properties.Settings.Default.checkNote;
                cmd.PrintString();
                cmd.Alignment = 2;
                cmd.Caption = cashierName.ToString();
                cmd.TextWrap = 2;
                cmd.PrintString();

                Double sum = 0;

                lastElements.Clear();

                foreach (entities.Product element in cart.GetElements())
                {
                    cmd.Name = element.GetName();
                    cmd.Price = element.GetPrice();
                    cmd.Quantity = element.GetCartCount();
                    sum += element.GetPrice() * element.GetCartCount();
                    cmd.Buy();
                    //cmd.Registration();

                    lastElements.Add(element);
                }

                cmd.Summ = sum;

                cmd.Caption = "                              ";
                cmd.PrintString();
                cmd.Caption = "-------------------------DVIZH";
                cmd.PrintString();
                cmd.Caption = "                              ";
                cmd.PrintString();
                cmd.Caption = "                              ";
                cmd.PrintString();
                cmd.Caption = "                              ";
                cmd.PrintString();

                cmd.TypeClose = paymentType;
                cmd.Payment();
                cmd.CloseCheck();
                cmd.EndDocument();
            }
            //cmd.Beep();
            cmd.DeviceEnabled = 0;

            return true;
        }

        public Boolean OpenShift()
        {
            if (!DriverExists())
            {
                return false;
            }

            cmd.SlipDocCharLineLength = 32;
            cmd.SlipDocTopMargin = 0;
            cmd.SlipDocLeftMargin = 1;
            cmd.SlipDocOrientation = 0;

            cmd.DeviceEnabled = 1;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = 30;
                cmd.Mode = 1;
                cmd.SetMode();
                cmd.OpenSession();
                cmd.Beep();
            }

            cmd.DeviceEnabled = 0;

            return true;
        }

        public Boolean CloseShift()
        {
            if (!DriverExists())
            {
                return false;
            }

            cmd.SlipDocCharLineLength = 32;
            cmd.SlipDocTopMargin = 0;
            cmd.SlipDocLeftMargin = 1;
            cmd.SlipDocOrientation = 0;

            cmd.DeviceEnabled = 1;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = 30;
                cmd.Mode = 3;
                cmd.SetMode();
                cmd.ReportType = 1;
                cmd.Report();
                cmd.Beep();
            }
            cmd.DeviceEnabled = 0;

            return true;
        }
    }
}
