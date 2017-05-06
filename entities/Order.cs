using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    class Order
    {
        int id;
        int dvizh_id;
        string date;
        double total;
        string cancel_at;
        Cashier cashier;
        Client client;
        Discount promocode;

        private List<entities.OrderElement> elements = new List<entities.OrderElement>();

        public Order(int setId, string setDate, double setTotal)
        {
            id = setId;
            date = setDate;
            total = setTotal;
        }

        public void AddElement(entities.OrderElement element)
        {
            elements.Add(element);
        }

        public List<entities.OrderElement> GetElements()
        {
            return elements;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int DvizhId
        {
            get { return dvizh_id; }
            set { dvizh_id = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public int GetId()
        {
            return id;
        }
    }
}
