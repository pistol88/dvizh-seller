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
    }
}
