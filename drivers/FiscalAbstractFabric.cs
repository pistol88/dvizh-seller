using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.drivers
{
    class FiscalAbstractFabric : FiscalAbstractFabricInterface
    {
        public FiscalInterface Build()
        {
            if(Properties.Settings.Default.fiscalDriverType == 0)
            {
                return new VikiPrint(Properties.Settings.Default.fiscalComPort, 57600);
            }

            return new Atol();
        }
    }
}
