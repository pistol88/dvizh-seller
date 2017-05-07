using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DvizhSeller.services
{
    class DataMapper
    {
        string dbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\" + Properties.Settings.Default.dbFile + "; Integrated Security=True;Connect Timeout=" + Properties.Settings.Default.dbTimeout.ToString();
        SqlConnection connection;

        public DataMapper()
        {
            connection = new SqlConnection(dbConnectionString);
            connection.Open();
        }

        ~DataMapper()
        {
            //connection.Close();
        }

        public void SetConnectionString(string setDbConnectionString)
        {
            dbConnectionString = setDbConnectionString;
        }

        public bool FillProducts(repositories.Product productRepository, repositories.Category categoryRepository)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM product", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string sku = reader.GetString(1);
                    string name = reader.GetString(2);
                    double price = Convert.ToDouble(reader.GetDecimal(3));
                    dynamic category = null;
                    string image;
                    int amount;
                    
                    if (!reader.IsDBNull(5))
                        image = reader.GetString(5);
                    else
                        image = null;

                    if (!reader.IsDBNull(6))
                        amount = reader.GetInt32(6);
                    else
                        amount = 0;

                    
                    if (!reader.IsDBNull(4))
                        category = categoryRepository.FindOne(reader.GetInt32(4));
                    else
                        category = null;
                    
                    entities.Product product = new entities.Product(id, sku, name, price, category, image, amount);

                    productRepository.Add(product);
                }
            }

            reader.Close();

            return true;
        }

        public bool FillCategories(repositories.Category categoryRepository)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM category", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    entities.Category category = new entities.Category(reader.GetInt32(0), reader.GetString(1));
                    categoryRepository.Add(category);
                }
            }

            reader.Close();

            return true;
        }

        public bool FillClients(repositories.Client clientRepository)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM client", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string phone;

                    if (!reader.IsDBNull(2))
                        phone = reader.GetString(2);
                    else
                        phone = "";

                    entities.Client client = new entities.Client(reader.GetInt32(0), reader.GetString(1), phone);
                    clientRepository.Add(client);
                }
            }

            reader.Close();

            return true;
        }

        public bool FillCashboxes(repositories.Cashbox cashboxRepository)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM cashbox", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    entities.Cashbox cashbox = new entities.Cashbox(reader.GetInt32(0), reader.GetString(1));
                    cashboxRepository.Add(cashbox);
                }
            }

            reader.Close();

            return true;
        }

        public bool FillCashiers(repositories.Cashier cashierRepository)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM cashier", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    entities.Cashier cashbox = new entities.Cashier(reader.GetInt32(0), reader.GetString(1));
                    cashierRepository.Add(cashbox);
                }
            }

            reader.Close();

            return true;
        }

        public bool FillDiscounts(repositories.Discount discountRepository)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM discount", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    entities.Discount discount = new entities.Discount(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                    discountRepository.Add(discount);
                }
            }

            reader.Close();

            return true;
        }

        public bool FillOrders(repositories.Order orderRepository)
        {
            DateTime dt1 = DateTime.Now;
            string date = dt1.AddDays(-2).ToShortTimeString();

            SqlCommand command = new SqlCommand("SELECT * FROM order_list WHERE cancel_at IS NULL AND date > '" + date + "' ORDER BY id DESC", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    entities.Order order = new entities.Order(
                        reader.GetInt32(0), //id
                        reader.GetDateTime(3).ToLongTimeString(), //date
                        Convert.ToDouble(reader.GetDecimal(8)), //total
                        reader.GetInt32(2), //cashier
                        reader.GetInt32(7), //client
                        reader.GetInt32(6) //discount
                    );

                    orderRepository.Add(order);
                }
            }

            reader.Close();

            foreach(entities.Order order in orderRepository.GetList())
            {
                SqlCommand elementCommand = new SqlCommand("SELECT * FROM order_element_list WHERE order_id = " + order.GetId().ToString(), connection);

                SqlDataReader elementReader = elementCommand.ExecuteReader();

                if (elementReader.HasRows)
                {
                    while (elementReader.Read())
                    {
                        entities.OrderElement element = new entities.OrderElement(elementReader.GetInt32(0), elementReader.GetString(3), Convert.ToDouble(elementReader.GetDecimal(5)), elementReader.GetInt32(4));
                        order.AddElement(element);
                    }
                }

                elementReader.Close();
            }

            return true;
        }
    }
}
