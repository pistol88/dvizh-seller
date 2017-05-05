using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.repositories
{
    class Category
    {
        private List<entities.Category> categories = new List<entities.Category>();

        public void Add(entities.Category category)
        {
            categories.Add(category);
        }

        public void Delete(entities.Category category)
        {
            categories.Remove(category);
        }

        public List<entities.Category> GetList()
        {
            return categories;
        }

        public entities.Category FindOne(int id)
        {
            return categories.Find(x => x.GetId() == id);
        }

        public List<entities.Category> FindByName(string name)
        {
            return categories.FindAll(x => x.GetName().Contains(name));
        }
    }
}
