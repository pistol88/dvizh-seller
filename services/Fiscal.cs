using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DvizhSeller.services
{

    class Fiscal
    {
        repositories.Cart cart;
        public List<entities.Product> lastElements;
        FprnM1C.IFprnM45 cmd;
        bool driverExists;

        public Fiscal(repositories.Cart setCart = null)
        {
            cart = setCart;
            lastElements = new List<entities.Product>();

            try
            {
                cmd = new FprnM1C.FprnM45();

                driverExists = true;

                if (cmd.CheckState != 0)
                    cmd.CancelCheck();

                if(cmd.SessionExceedLimit)
                {
                    MessageBox.Show("Продолжительность смены превысила 24 часа. Закройте и снова откройте смену.");
                    driverExists = false;
                }
            }
            catch (Exception)
            {
                driverExists = false;
            }
            
        }

        public Boolean DriverExists()
        {
            return driverExists;
        }

        public Boolean TestPrint()
        {
            if (!DriverExists())
            {
                MessageBox.Show("Не удалось подключиться. Проверьте, установлен ли драйвер.");
                return false;
            }

            cmd.DeviceEnabled = true;

            cmd.Alignment = 1;
            cmd.Caption = "-------------------------DVIZH";
            cmd.PrintString();

            cmd.Alignment = 1;
            cmd.Caption = "Тестирование печати.";
            cmd.PrintString();

            cmd.Alignment = 1;
            cmd.Caption = "Все ОК.";
            cmd.PrintString();

            cmd.Beep();

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

            cmd.Alignment = 1;
            cmd.Caption = "-------------------------DVIZH";
            cmd.PrintString();

            cmd.Alignment = 1;
            cmd.Caption = "                ";
            cmd.PrintString();

            cmd.Alignment = 1;
            cmd.Caption = "                ";
            cmd.PrintString();

            return true;
        }

        public void March()
        {
            if (!DriverExists())
            {
                return;
            }

            cmd.DeviceEnabled = true;

            cmd.Password = "30";
            cmd.Mode = 1;
            cmd.SetMode();

            cmd.Frequency = 261;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 261;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 261;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 349;
            cmd.Duration = 350;
            cmd.Sound();

            cmd.Frequency = 523;
            cmd.Duration = 150;
            cmd.Sound();

            cmd.Frequency = 261;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 349;
            cmd.Duration = 350;
            cmd.Sound();

            cmd.Frequency = 523;
            cmd.Duration = 150;
            cmd.Sound();

            cmd.Frequency = 261;
            cmd.Duration = 650;
            cmd.Sound();
            //
            cmd.Frequency = 659;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 659;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 659;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 698;
            cmd.Duration = 350;
            cmd.Sound();

            cmd.Frequency = 523;
            cmd.Duration = 150;
            cmd.Sound();

            cmd.Frequency = 415;
            cmd.Duration = 500;
            cmd.Sound();

            cmd.Frequency = 349;
            cmd.Duration = 350;
            cmd.Sound();

            cmd.Frequency = 523;
            cmd.Duration = 150;
            cmd.Sound();

            cmd.Frequency = 261;
            cmd.Duration = 650;
            cmd.Sound();
        }

        public Boolean SessionOpened()
        {
            if (!DriverExists())
            {
                return false;
            }

            cmd.DeviceEnabled = true;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = "30";
                cmd.Mode = 1;
                cmd.SetMode();

                return cmd.SessionOpened;
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

            cmd.DeviceEnabled = true;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = "30";
                cmd.Mode = 1;
                cmd.SetMode();
                cmd.TestMode = Properties.Settings.Default.testMode;
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
            cmd.DeviceEnabled = false;

            return true;
        }

        public Boolean Register(string cashierName, int paymentType = 0, bool discount = false, int discountType = 1, int discountVal = 0)
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

            cmd.DeviceEnabled = true;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = "30";
                cmd.Mode = 1;
                cmd.SetMode();
                cmd.TestMode = Properties.Settings.Default.testMode;
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

                int i = 1;

                foreach (entities.Product element in cart.GetElements())
                {
                    cmd.Name = element.GetName();
                    cmd.Price = element.GetPrice();
                    cmd.Quantity = element.GetCartCount();
                    cmd.Department = i;
                    sum += element.GetPrice() * element.GetCartCount();
                    i++;
                    //cmd.Buy();
                    cmd.Registration();

                    lastElements.Add(element);
                }

                cmd.Summ = sum;

                if(discount)
                {
                    cmd.DiscountType = discountType;
                    cmd.DiscountValue = discountVal;
                }

                cmd.Caption = "                              ";
                cmd.PrintString();
                cmd.Caption = "-------------------------DVIZH";
                cmd.PrintString();
                cmd.Caption = "                              ";

                cmd.TypeClose = paymentType;
                cmd.Payment();

                //cmd.Registration();

                cmd.CloseCheck();
                cmd.EndDocument();
            }
            //cmd.Beep();
            cmd.DeviceEnabled = false;

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

            cmd.DeviceEnabled = true;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = "30";
                cmd.Mode = 1;
                cmd.SetMode();
                cmd.OpenSession();
                cmd.Beep();
            }

            cmd.DeviceEnabled = false;

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

            cmd.DeviceEnabled = true;

            if (cmd.GetStatus() < 0)
            {
                return false;
            }
            else
            {
                cmd.Password = "30";
                cmd.Mode = 3;
                cmd.SetMode();
                cmd.ReportType = 1;
                cmd.Report();
                cmd.Beep();
            }
            cmd.DeviceEnabled = false;

            return true;
        }
    }
}
