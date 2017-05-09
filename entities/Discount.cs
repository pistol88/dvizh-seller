using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    class Discount
    {
        int id;
        int discount;
        string code;

        public Discount(int setId, string setCode, int setDiscount)
        {
            id = setId;
            code = setCode;
            discount = setDiscount;
        }

        public string GetName()
        {
            return code;
        }

        public string GetCode()
        {
            return code;
        }

        public int GetDiscount()
        {
            return discount;
        }

        public int GetId()
        {
            return id;
        }

        public void SetCode(string setCode)
        {
            code = setCode;
        }

        public void SetDiscount(int setDiscount)
        {
            discount = setDiscount;
        }

        public void SetId(int setId)
        {
            id = setId;
        }
    }
}
