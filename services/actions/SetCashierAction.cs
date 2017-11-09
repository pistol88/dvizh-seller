using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.services.actions
{

    public class SetCashierAction
    {
        public string jsonrpc { get; set; }
        public string method { get; set; }
        public SetCashierParams _params { get; set; }
    }

    public class SetCashierParams
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}
