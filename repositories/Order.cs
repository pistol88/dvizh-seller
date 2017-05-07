using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DvizhSeller.repositories
{
    class Order
    {
        private List<entities.Order> orders = new List<entities.Order>();

        public void Add(entities.Order order)
        {
            orders.Add(order);
        }

        public void AddWithSql(entities.Order order)
        {
            Add(order);

            string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\" + Properties.Settings.Default.dbFile + "; Integrated Security=True;Connect Timeout=" + Properties.Settings.Default.dbTimeout.ToString();
            SqlConnection connection = new SqlConnection(dbConnectionString);
            connection.Open();

            SqlCommand orderCommand = new SqlCommand("INSERT INTO order_list(date, total, cashier_id, client_id, discount_id) OUTPUT INSERTED.ID VALUES(@date, @total, @cashier_id, @client_id, @discount_id)", connection);

            orderCommand.Parameters.AddWithValue("@date", order.Date);
            orderCommand.Parameters.AddWithValue("@cashier_id", order.cashierId);
            orderCommand.Parameters.AddWithValue("@client_id", order.clientId);
            orderCommand.Parameters.AddWithValue("@discount_id", order.discountId);
            orderCommand.Parameters.AddWithValue("@total", order.Total.ToString());
            
            order.Id = (int) orderCommand.ExecuteScalar();

            foreach (entities.OrderElement element in order.GetElements())
            {
                SqlCommand elementCommand = new SqlCommand("INSERT INTO order_element_list(order_id, product_id, product_name, count, price) values(@order_id, @product_id, @product_name, @count, @price)", connection);

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
