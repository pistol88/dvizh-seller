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
        int cashier_id;
        int client_id;
        int discount_id;

        private List<entities.OrderElement> elements = new List<entities.OrderElement>();

        public Order(int setId, string setDate, double setTotal, int setCashier, int setClient, int setDiscount)
        {
            id = setId;
            date = setDate;
            total = setTotal;
            cashier_id = setCashier;
            client_id = setClient;
            discount_id = setDiscount;
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

        public int cashierId
        {
            get { return cashier_id; }
            set { cashier_id = value; }
        }

        public int clientId
        {
            get { return client_id; }
            set { client_id = value; }
        }

        public int discountId
        {
            get { return discount_id; }
            set { discount_id = value; }
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
