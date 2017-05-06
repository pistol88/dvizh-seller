using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.services
{
    class Rounder
    {
        public double Round(double num)
        {
            switch(Properties.Settings.Default.roundingType)
            {
                case 0:
                    return Math.Round(num, Properties.Settings.Default.rounding);
                case 1: //До 1
                    return Math.Round(num);
                case 2: //до 5
                    return RoundFive(num);
                case 3: //до 10
                    return Math.Round(Math.Round(num / 10) * 10);
            }

            return num;
        }

        public static int RoundFive(double d)
        {
            if (d % 5 > 2.5)
                return (int)(d / 5) * 5 + 5;
            else
                return (int)(d / 5) * 5;
        }
    }
}
