using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    class Cashier
    {
        int id;
        string name;

        public Cashier(int setId, string setName)
        {
            id = setId;
            name = setName;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GetName()
        {
            return name;
        }

        public int GetId()
        {
            return id;
        }

        public void SetName(string setName)
        {
            name = setName;
        }

        public void SetId(int setId)
        {
            id = setId;
        }
    }
}
