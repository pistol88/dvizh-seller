using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    class Product : interfaces.CartElement
    {
        int id;
        string name;
        string sku;
        string image;
        int amount;
        double price;
        Category category = null;
        int categoryId = 0;
        int cartcount = 1;

        public Product(int setId, string setSku, string setName, double setPrice, Category setCategory = null, string setImage = null, int setAmount = 0)
        {
            id = setId;
            sku = setSku;
            name = setName;
            price = setPrice;
            image = setImage;
            amount = setAmount;

            if (setCategory != null)
            {
                category = setCategory;
                categoryId = category.GetId();
            }
        }

        private void updateDb()
        {
            //EventHandler<UpdateEventArgs> handler = 1;

            //if (handler != null)
            //{
            //    handler(this, e);
            //}
        }

        public string Name
        {
            get { return name; }
            set {
                name = value;
                updateDb();
            }
        }

        public string Sku
        {
            get { return sku; }
            set { sku = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public int CartCount
        {
            get { return cartcount; }
            set { cartcount = value; }
        }

        public string GetName()
        {
            return name;
        }

        public int GetId()
        {
            return id;
        }

        public Category GetCategory()
        {
            return category;
        }

        public int GetCategoryId()
        {
            return categoryId;
        }

        public double GetPrice()
        {
            return price;
        }

        public string GetSku()
        {
            return sku;
        }

        public int GetAmount()
        {
            return amount;
        }

        public string GetImage()
        {
            return image;
        }

        public string GetNameAndSku()
        {
            return sku + " " + name;
        }

        public int GetCartCount()
        {
            return cartcount;
        }

        public void SetCartCount(int count)
        {
            cartcount = count;
        }

        public void SetName(string setName)
        {
            name = setName;
        }
        
        public void SetCategoryId(int setCategoryId)
        {
            categoryId = setCategoryId;
        }

        public void SetPrice(double setPrice)
        {
            price = setPrice;
        }

        public void SetSku(string setSku)
        {
            sku = setSku;
        }

        public void SetAmount(int setAmount)
        {
            amount = setAmount;
        }

        public void SetImage(string setImage)
        {
            image = setImage;
        }
    }

    public class UpdateEventArgs : EventArgs
    {
        //public Product product { get; set; }
    }
}
