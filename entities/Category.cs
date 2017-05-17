using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.entities
{
    class Category
    {
        int id;
        string name;
        int parent_id;

        public Category(int setId, string setName)
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

        public int GetParentId()
        {
            return parent_id;
        }

        public void SetParentId(int setParent_id)
        {
            parent_id = setParent_id;
        }

        public void SetId(int setId)
        {
            id = setId;
        }

        public void SetName(string setName)
        {
            name = setName;
        }
    }
}
