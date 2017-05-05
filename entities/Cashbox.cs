using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    class Cashbox
    {
        int id;
        string name;

        public Cashbox(int setId, string setName)
        {
            id = setId;
            name = setName;
        }

        public string GetName()
        {
            return name;
        }

        public int GetId()
        {
            return id;
        }
    }
}
