using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.repositories
{
    class Discount
    {
        private List<entities.Discount> discounts = new List<entities.Discount>();

        public void Add(entities.Discount discount)
        {
            discounts.Add(discount);
        }

        public void Delete(entities.Discount discount)
        {
            discounts.Remove(discount);
        }

        public List<entities.Discount> GetList()
        {
            return discounts;
        }

        public entities.Discount FindOne(int id)
        {
            return discounts.Find(x => x.GetId() == id);
        }

        public entities.Discount FindOneByName(string name)
        {
            return discounts.Find(x => x.GetName().ToLower().Trim() == name.ToLower().Trim());
        }

        public List<entities.Discount> FindByName(string name)
        {
            return discounts.FindAll(x => x.GetName().Contains(name));
        }
    }
}
