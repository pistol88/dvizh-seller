using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DvizhSeller.repositories
{
    class Category
    {
        private List<entities.Category> categories = new List<entities.Category>();

        services.Database db;

        public Category(services.Database setDb)
        {
            db = setDb;
        }

        public void Add(entities.Category category)
        {
            categories.Add(category);
        }

        public int SaveWithSql(entities.Category category)
        {
            entities.Category hasCategory = FindOne(category.GetId());

            SQLiteCommand command;

            if (hasCategory == null)
            {
                Add(category);
                command = new SQLiteCommand("INSERT INTO category(name, parent_id) VALUES(@name, @parent_id)", db.connection);
            }
            else
            {
                command = new SQLiteCommand("UPDATE category SET name = @name, parent_id = @parent_id WHERE id = @id ", db.connection);
            }

            command.Parameters.AddWithValue("@id", category.GetId());
            command.Parameters.AddWithValue("@name", category.GetName());
            command.Parameters.AddWithValue("@parent_id", category.GetParentId());

            int num = command.ExecuteNonQuery();

            return num;
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
