using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DvizhSeller.repositories
{
    class Cashier
    {
        private List<entities.Cashier> cashiers = new List<entities.Cashier>();

        services.Database db;

        public Cashier(services.Database setDb)
        {
            db = setDb;
        }

        public void Add(entities.Cashier cashier)
        {
            cashiers.Add(cashier);
        }

        public int SaveWithSql(entities.Cashier cashier)
        {
            entities.Cashier hasCashier = FindOne(cashier.GetId());

            SQLiteCommand command;

            if (hasCashier == null)
            {
                Add(cashier);
                command = new SQLiteCommand("INSERT INTO cashier(id, name) VALUES(@id, @name)", db.connection);
            }
            else
            {
                command = new SQLiteCommand("UPDATE cashier SET name = @name WHERE id = @id ", db.connection);
            }

            command.Parameters.AddWithValue("@id", cashier.GetId());
            command.Parameters.AddWithValue("@name", cashier.GetName());

            int num = command.ExecuteNonQuery();

            return num;
        }

        public int DeleteWithSql(entities.Cashier cashier)
        {
            entities.Cashier hasCashier = FindOne(cashier.GetId());

            SQLiteCommand command;

            command = new SQLiteCommand("DELETE FROM cashier WHERE id = @id", db.connection);

            command.Parameters.AddWithValue("@id", cashier.GetId());

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

        public void Clear()
        {
            cashiers.Clear();
        }
    }
}
