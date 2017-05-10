using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.repositories
{
    class Cashbox
    {
        private List<entities.Cashbox> cashboxes = new List<entities.Cashbox>();

        services.Database db;

        public Cashbox(services.Database setDb)
        {
            db = setDb;
        }

        public void Add(entities.Cashbox cashbox)
        {
            cashboxes.Add(cashbox);
        }

        public void Delete(entities.Cashbox cashbox)
        {
            cashboxes.Remove(cashbox);
        }

        public List<entities.Cashbox> GetList()
        {
            return cashboxes;
        }

        public entities.Cashbox FindOne(int id)
        {
            return cashboxes.Find(x => x.GetId() == id);
        }

        public List<entities.Cashbox> FindByName(string name)
        {
            return cashboxes.FindAll(x => x.GetName().Contains(name));
        }
    }
}
