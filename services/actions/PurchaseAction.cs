using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.services.actions
{

    public class PurchaseAction
    {
        public string jsonrpc { get; set; }
        public string method { get; set; }
        public PurchaseParams _params { get; set; }

        services.Fiscal fiscal;

        public void purchase()
        {
            repositories.Cart cart = new repositories.Cart();
            if (this._params.discount > 0)
            {
                entities.Discount discount = new entities.Discount(1, "disc", this._params.discount);
                discount.SetType(this._params.discount_type);
                cart.SetDiscount(discount);
            }
            foreach (var product in this._params.elements)
            {
                cart.Put(product,product.CartCount);
            }
            Properties.Settings.Default.taxType = this._params.tax_id;
            fiscal = new services.Fiscal(new drivers.FiscalAbstractFabric(), cart);
            fiscal.SetTax(this._params.tax_id);
            fiscal.Register(this._params.payment_type);
        }
    }

    public class PurchaseParams
    {
        public byte payment_type { get; set; }
        public int discount { get; set; }
        public byte discount_type { get; set; }
        public byte tax_id { get; set; }
        public entities.Product[] elements { get; set; }

        public int GetPayment()
        {
            return payment_type;
        }

        public int GetDiscount()
        {
            return discount;
        }

        public int GetTax()
        {
            return tax_id;
        }
    }

}   


