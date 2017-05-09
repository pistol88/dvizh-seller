using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DvizhSeller.repositories
{
    class Cashier
    {
        private List<entities.Cashier> cashiers = new List<entities.Cashier>();

        public void Add(entities.Cashier cashier)
        {
            cashiers.Add(cashier);
        }

        public int SaveWithSql(entities.Cashier cashier)
        {
            string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\" + Properties.Settings.Default.dbFile + "; Integrated Security=True;Connect Timeout=" + Properties.Settings.Default.dbTimeout.ToString();
            SqlConnection connection = new SqlConnection(dbConnectionString);
            connection.Open();

            entities.Cashier hasCashier = FindOne(cashier.GetId());

            SqlCommand command;

            if (hasCashier == null)
            {
                Add(cashier);
                command = new SqlCommand("INSERT INTO cashier(id, name) VALUES(@id, @name)", connection);
            }
            else
            {
                command = new SqlCommand("UPDATE cashier SET name = @name WHERE id = @id ", connection);
            }

            command.Parameters.AddWithValue("@id", cashier.GetId());
            command.Parameters.AddWithValue("@name", cashier.GetName());

            int num = command.ExecuteNonQuery();

            return num;
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
