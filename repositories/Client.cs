using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.repositories
{
    class Client
    {
        private List<entities.Client> clients = new List<entities.Client>();

        public void Add(entities.Client category)
        {
            clients.Add(category);
        }

        public void Delete(entities.Client category)
        {
            clients.Remove(category);
        }

        public List<entities.Client> GetList()
        {
            return clients;
        }

        public entities.Client FindOne(int id)
        {
            return clients.Find(x => x.GetId() == id);
        }

        public List<entities.Client> FindByString(string str)
        {
            return clients.FindAll(x => x.GetNameAndPhone().Contains(str));
        }

        public List<entities.Client> FindByName(string name)
        {
            return clients.FindAll(x => x.GetName().Contains(name));
        }

        public List<entities.Client> FindByPhone(string name)
        {
            return clients.FindAll(x => x.GetPhone().Contains(name));
        }
    }
}
