using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DvizhSeller.repositories
{
    class Order
    {
        private List<entities.Order> orders = new List<entities.Order>();

        services.Database db;

        public Order(services.Database setDb)
        {
            db = setDb;
        }

        public void Add(entities.Order order)
        {
            orders.Add(order);
        }

        public void SaveDvizhIdWithSql(entities.Order order, int dvizhId)
        {
            SQLiteCommand orderCommand = new SQLiteCommand("UPDATE order_list SET dvizh_id = @dvizh_id WHERE id = @id", db.connection);

            orderCommand.Parameters.AddWithValue("@dvizh_id", dvizhId);
            orderCommand.Parameters.AddWithValue("@id", order.GetId());

            orderCommand.ExecuteNonQuery();
        }

        public void CancelElement(entities.OrderElement element)
        {
            SQLiteCommand orderCommand = new SQLiteCommand("UPDATE order_element_list SET cancel_at = @cancel_at WHERE id = @id", db.connection);

            orderCommand.Parameters.AddWithValue("@cancel_at", DateTime.Now.ToLongDateString());
            orderCommand.Parameters.AddWithValue("@id", element.GetId());

            orderCommand.ExecuteNonQuery();
        }

        public void AddWithSql(entities.Order order)
        {
            Add(order);

            SQLiteCommand orderCommand;

            orderCommand = new SQLiteCommand("INSERT INTO order_list(dvizh_id, date, total, cashier_id, client_id, discount_id) VALUES(@dvizh_id, @date, @total, @cashier_id, @client_id, @discount_id)", db.connection);

            orderCommand.Parameters.AddWithValue("@dvizh_id", order.DvizhId);
            orderCommand.Parameters.AddWithValue("@date", order.Date);
            orderCommand.Parameters.AddWithValue("@cashier_id", order.cashierId);
            orderCommand.Parameters.AddWithValue("@client_id", order.clientId);
            orderCommand.Parameters.AddWithValue("@discount_id", order.discountId);
            orderCommand.Parameters.AddWithValue("@total", order.Total.ToString());

            orderCommand.ExecuteNonQuery();

            orderCommand.CommandText = "SELECT last_insert_rowid()";
            
            Int64 LastRowID64 = (Int64)orderCommand.ExecuteScalar();

            order.Id = (int)LastRowID64;

            foreach (entities.OrderElement element in order.GetElements())
            {
                SQLiteCommand elementCommand = new SQLiteCommand("INSERT INTO order_element_list(order_id, product_id, product_name, count, price) values(@order_id, @product_id, @product_name, @count, @price)", db.connection);

                elementCommand.Parameters.AddWithValue("@order_id", order.GetId());
                elementCommand.Parameters.AddWithValue("@product_id", element.GetProductId());
                elementCommand.Parameters.AddWithValue("@product_name", element.GetProductName());
                elementCommand.Parameters.AddWithValue("@count", element.GetCount());
                elementCommand.Parameters.AddWithValue("@price", element.GetPrice().ToString());

                elementCommand.ExecuteNonQuery();
            }
        }

        public void Delete(entities.Order order)
        {
            orders.Remove(order);
        }

        public List<entities.Order> GetList()
        {
            return orders;
        }

        public entities.Order FindOne(int id)
        {
            return orders.Find(x => x.GetId() == id);
        }
    }
}
