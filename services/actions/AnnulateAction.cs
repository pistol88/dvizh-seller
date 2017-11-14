using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.services.actions
{
    public class AnnulateAction
    {
        public string jsonrpc { get; set; }
        public string method { get; set; }
        public AnnulateParams _params { get; set; }
    }

    public class AnnulateParams
    {
        public entities.OrderElement[] elements { get; set; }
    }
}
