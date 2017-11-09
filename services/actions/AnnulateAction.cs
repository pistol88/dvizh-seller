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
        public Element[] elements { get; set; }
    }

    public class Element
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sku { get; set; }
        public float price { get; set; }
        public int tax_id { get; set; }
    }

}
