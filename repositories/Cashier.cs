using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.repositories
{
    class Cashier
    {
        private List<entities.Cashier> cashiers = new List<entities.Cashier>();

        public void Add(entities.Cashier cashbox)
        {
            cashiers.Add(cashbox);
        }

        public void Delete(entities.Cashier cashbox)
        {
            cashiers.Remove(cashbox);
        }

        public List<entities.Cashier> GetList()
        {
            return cashiers;
        }

        public entities.Cashier FindOne(int id)
        {
            return cashiers.Find(x => x.GetId() == id);
        }

        public List<entities.Cashier> FindByName(string name)
        {
            return cashiers.FindAll(x => x.GetName().Contains(name));
        }
    }
}
