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
        string name;

        public Discount(int setId, string setName, int setDiscount)
        {
            id = setId;
            name = setName;
            discount = setDiscount;
        }

        public string GetName()
        {
            return name;
        }

        public int GetDiscount()
        {
            return discount;
        }

        public int GetId()
        {
            return id;
        }
    }
}
