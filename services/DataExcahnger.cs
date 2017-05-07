using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DvizhSeller.services
{
    class DataExcahnger
    {
        public int SendOrder()
        {
            return 0;
        }

        public void LoadProducts()
        {
            String csv = new WebClient().DownloadString(Properties.Settings.Default.protocol + "://" + Properties.Settings.Default.client + "." + Properties.Settings.Default.host + "/backend/web/csvapi/products?token=" + Properties.Settings.Default.token);
        }
    }
}
