using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    public class OrderElement
    {
        int id;
        int productId;
        string productName;
        double price;
        int count;
        string cancel_at;

        public OrderElement(int setId, int setProductId, string setProductName, double setPrice, int setCount, string setCancelAt)
        {
            id = setId;
            productId = setProductId;
            productName = setProductName;
            price = setPrice;
            count = setCount;
            cancel_at = setCancelAt;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string CancelAt
        {
            get { return cancel_at; }
            set { cancel_at = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public int GetProductId()
        {
            return productId;
        }
    
        public string GetProductName()
        {
            return productName;
        }

        public int GetId()
        {
            return id;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetCount()
        {
            return count;
        }

        public void SetCancelAt(string date)
        {
            cancel_at = date;
        }
    }
}
