using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DvizhSeller.services
{
    class DataMapper
    {
        Database db;

        public DataMapper(Database setDb)
        {
            db = setDb;
        }

        public bool FillProducts(repositories.Product productRepository, repositories.Category categoryRepository)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM product", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

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

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM category", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

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
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM client", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

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
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM cashbox", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

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
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM cashier", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //MessageBox.Show(reader["name"].ToString());
                    entities.Cashier cashbox = new entities.Cashier(Convert.ToInt32(reader["id"].ToString()), reader["name"].ToString());
                    cashierRepository.Add(cashbox);
                }
            }

            reader.Close();

            return true;
        }

        public bool FillDiscounts(repositories.Discount discountRepository)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM discount", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

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

        public static entities.Order BuildOrder(SQLiteDataReader reader)
        {
            int dvizhId = 0;

            if (!reader.IsDBNull(1))
                dvizhId = reader.GetInt32(1);
            else
                dvizhId = 0;

            return new entities.Order(
                        reader.GetInt32(0), //id
                        reader.GetString(3), //date
                        Convert.ToDouble(reader["total"].ToString()), //total
                        reader.GetInt32(2), //cashier
                        reader.GetInt32(7), //client
                        reader.GetInt32(6), //discount
                        dvizhId //dvizh id
                    );
        }

        public bool FillOrders(repositories.Order orderRepository)
        {
            DateTime dt1 = DateTime.Now;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM order_list WHERE cancel_at IS NULL ORDER BY id DESC LIMIT 1000", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    entities.Order order = BuildOrder(reader);

                    orderRepository.Add(order);
                }
            }

            reader.Close();

            foreach(entities.Order order in orderRepository.GetList())
            {
                SQLiteCommand elementCommand = new SQLiteCommand("SELECT * FROM order_element_list WHERE order_id = " + order.GetId().ToString(), db.connection);

                SQLiteDataReader elementReader = elementCommand.ExecuteReader();

                if (elementReader.HasRows)
                {
                    while (elementReader.Read())
                    {
                        string cancelAt;

                        if (!elementReader.IsDBNull(6))
                            cancelAt = elementReader.GetString(6);
                        else
                            cancelAt = "";

                        entities.OrderElement element = new entities.OrderElement(elementReader.GetInt32(0), elementReader.GetInt32(1), elementReader.GetString(3), Convert.ToDouble(elementReader.GetDecimal(5)), elementReader.GetInt32(4), cancelAt);
                        order.AddElement(element);
                    }
                }

                elementReader.Close();
            }

            return true;
        }
    }
}
