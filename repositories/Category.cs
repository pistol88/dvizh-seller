using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DvizhSeller.repositories
{
    class Category
    {
        private List<entities.Category> categories = new List<entities.Category>();

        public void Add(entities.Category category)
        {
            categories.Add(category);
        }


        public int SaveWithSql(entities.Category category)
        {
            string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\" + Properties.Settings.Default.dbFile + "; Integrated Security=True;Connect Timeout=" + Properties.Settings.Default.dbTimeout.ToString();
            SqlConnection connection = new SqlConnection(dbConnectionString);
            connection.Open();

            entities.Category hasCategory = FindOne(category.GetId());

            SqlCommand command;

            if (hasCategory == null)
            {
                Add(category);
                command = new SqlCommand("INSERT INTO category(id, name, parent_id) VALUES(@id, @name, @parent_id)", connection);
            }
            else
            {
                command = new SqlCommand("UPDATE category SET name = @name, parent_id = @parent_id WHERE id = @id ", connection);
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
