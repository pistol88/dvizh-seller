using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DvizhSeller.repositories
{
    class Discount
    {
        private List<entities.Discount> discounts = new List<entities.Discount>();

        public void Add(entities.Discount discount)
        {
            discounts.Add(discount);
        }

        public int SaveWithSql(entities.Discount discount)
        {
            string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\" + Properties.Settings.Default.dbFile + "; Integrated Security=True;Connect Timeout=" + Properties.Settings.Default.dbTimeout.ToString();
            SqlConnection connection = new SqlConnection(dbConnectionString);
            connection.Open();

            entities.Discount hasDiscount = FindOne(discount.GetId());

            SqlCommand command;

            if (hasDiscount == null)
            {
                Add(discount);
                command = new SqlCommand("INSERT INTO discount(id, code, discount) VALUES(@id, @code, @discount)", connection);
            }
            else
            {
                command = new SqlCommand("UPDATE discount SET code = @code, discount = @discount WHERE id = @id ", connection);
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

        public List<entities.Discount> FindByName(string name)
        {
            return discounts.FindAll(x => x.GetCode().Contains(name));
        }
    }
}
