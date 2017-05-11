using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DvizhSeller.repositories
{
    class Discount
    {
        private List<entities.Discount> discounts = new List<entities.Discount>();

        services.Database db;

        public Discount(services.Database setDb)
        {
            db = setDb;
        }

        public void Add(entities.Discount discount)
        {
            discounts.Add(discount);
        }

        public int SaveWithSql(entities.Discount discount)
        {
            entities.Discount hasDiscount = FindOne(discount.GetId());

            SQLiteCommand command;

            if (hasDiscount == null)
            {
                Add(discount);
                command = new SQLiteCommand("INSERT INTO discount(id, code, discount) VALUES(@id, @code, @discount)", db.connection);
            }
            else
            {
                command = new SQLiteCommand("UPDATE discount SET code = @code, discount = @discount WHERE id = @id ", db.connection);
            }

            command.Parameters.AddWithValue("@id", discount.GetId());
            command.Parameters.AddWithValue("@code", discount.GetCode());
            command.Parameters.AddWithValue("@discount", discount.GetDiscount());

            int num = command.ExecuteNonQuery();

            return num;
        }

        public void Delete(entities.Discount discount)
        {
            discounts.Remove(discount);
        }

        public List<entities.Discount> GetList()
        {
            return discounts;
        }

        public entities.Discount FindOne(int id)
        {
            return discounts.Find(x => x.GetId() == id);
        }

        public entities.Discount FindOneByName(string name)
        {
            return discounts.Find(x => x.GetCode().ToLower().Trim() == name.ToLower().Trim());
        }

        public List<entities.Discount> FindByCode(string name)
        {
            return discounts.FindAll(x => x.GetCode().Contains(name));
        }

        public List<entities.Discount> FindByName(string name)
        {
            return discounts.FindAll(x => x.GetCode().Contains(name));
        }
    }
}
