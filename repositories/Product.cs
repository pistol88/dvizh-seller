using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.repositories
{
    class Product
    {
        private List<entities.Product> products = new List<entities.Product>();

        public void Add(entities.Product product)
        {
            products.Add(product);
        }

        public void Delete(entities.Product product)
        {
            products.Remove(product);
        }

        public List<entities.Product> GetList()
        {
            return products;
        }

        public entities.Product FindOne(int id)
        {
            return products.Find(x => x.GetId() == id);
        }

        public List<entities.Product> FindByString(string str)
        {
            return products.FindAll(x => x.GetNameAndSku().ToLower().Contains(str.ToLower()));
        }

        public List<entities.Product> FindByCategory(entities.Category category)
        {
            return products.FindAll(x => x.GetCategoryId() == category.GetId());
        }

        public List<entities.Product> FindByCategoryId(int categoryId)
        {
            return products.FindAll(x => x.GetCategoryId() == categoryId);
        }

        public List<entities.Product> FindBySku(string sku)
        {
            return products.FindAll(x => x.GetSku() == sku);
        }

        public entities.Product FindOneBySku(string sku)
        {
            return products.Find(x => x.GetSku() == sku);
        }
    }
}
