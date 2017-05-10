using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DvizhSeller.services
{
    class DataExchanger
    {
        Database db;

        public DataExchanger(Database setDb)
        {
            db = setDb;
        }

        public Tuple<int, int, int> LoadProducts(repositories.Product products, repositories.Category categories)
        {
            List<string[]> lines = ParseCsv(GetCsvString("products"));

            int added = 0, changeprice = 0, changeamount = 0;

            foreach (string[] line in lines)
            {
                int id = Convert.ToInt32(line[0]);
                string sku = line[1];
                string name = line[2];
                double price = Convert.ToDouble(line[3]);

                int category_id;
                if (line[4] != "")
                    category_id = Convert.ToInt32(line[4]);
                else
                    category_id = 0;

                string image = line[5];

                int amount;
                if (line[6] != "")
                    amount = Convert.ToInt32(line[6]);
                else
                    amount = 0;

                entities.Product product = products.FindOne(id);
                if(product == null)
                {
                    dynamic category;

                    if (category_id != 0)
                        category = categories.FindOne(category_id);
                    else
                        category = null;

                    entities.Product addProduct = new entities.Product(id, sku, name, price, category, image, amount);
                    products.SaveWithSql(addProduct);

                    added++;
                }
                else
                {
                    if (product.GetPrice() != price)
                        changeprice++;

                    if (product.GetAmount() != amount)
                        changeamount++;

                    product.SetName(name);
                    product.SetSku(sku);
                    product.SetCategoryId(category_id);
                    product.SetPrice(price);
                    product.SetImage(image);
                    product.SetAmount(amount);

                    products.SaveWithSql(product);
                }
            }

            return new Tuple<int, int, int>(added, changeprice, changeamount);
        }

        public Tuple<int> LoadCategories(repositories.Category categories)
        {
            List<string[]> lines = ParseCsv(GetCsvString("categories"));

            int added = 0;

            foreach (string[] line in lines)
            {
                int id = Convert.ToInt32(line[0]);
                string name = line[1];

                int parent_id;

                if (line[2] != "")
                    parent_id = Convert.ToInt32(line[2]);
                else
                    parent_id = 0;

                entities.Category category = categories.FindOne(id);
                if (category == null)
                {
                    entities.Category addCategory = new entities.Category(id, name);
                    categories.SaveWithSql(addCategory);

                    added++;
                }
                else
                {
                    category.SetId(id);
                    category.SetName(name);
                    category.SetParentId(parent_id);

                    categories.SaveWithSql(category);
                }
            }

            return new Tuple<int>(added);
        }

        public Tuple<int> LoadClients(repositories.Client clients)
        {
            List<string[]> lines = ParseCsv(GetCsvString("clients"));

            int added = 0;

            foreach (string[] line in lines)
            {
                int id = Convert.ToInt32(line[0]);
                string name = line[1];
                string phone = line[2];

                entities.Client client = clients.FindOne(id);
                if (client == null)
                {
                    entities.Client addClient = new entities.Client(id, name, phone);

                    clients.SaveWithSql(addClient);
                }
                else
                {
                    client.SetId(id);
                    client.SetName(name);
                    client.SetPhone(phone);

                    clients.SaveWithSql(client);

                    added++;
                }
            }

            return new Tuple<int>(added);
        }

        public Tuple<int> LoadDiscounts(repositories.Discount discounts)
        {
            List<string[]> lines = ParseCsv(GetCsvString("discounts"));

            int added = 0;

            foreach (string[] line in lines)
            {
                int id = Convert.ToInt32(line[0]);
                string code = line[1];

                int discountSize;

                if (line[2] != "")
                    discountSize = Convert.ToInt32(line[2]);
                else
                    discountSize = 0;

                entities.Discount discount = discounts.FindOne(id);

                if (discount == null)
                {
                    entities.Discount addDiscount = new entities.Discount(id, code, discountSize);
                    discounts.SaveWithSql(addDiscount);
                }
                else
                {
                    discount.SetId(id);
                    discount.SetCode(code);
                    discount.SetDiscount(discountSize);

                    discounts.SaveWithSql(discount);

                    added++;
                }
            }

            return new Tuple<int>(added);
        }

        public Tuple<int> LoadCashiers(repositories.Cashier cashiers)
        {
            List<string[]> lines = ParseCsv(GetCsvString("cashiers"));

            int added = 0;

            foreach (string[] line in lines)
            {
                int id = Convert.ToInt32(line[0]);
                string name = line[1];

                entities.Cashier cashier = cashiers.FindOne(id);

                if (cashier == null)
                {
                    entities.Cashier addCashier = new entities.Cashier(id, name);
                    cashiers.SaveWithSql(addCashier);
                }
                else
                {
                    cashier.SetId(id);
                    cashier.SetName(name);

                    cashiers.SaveWithSql(cashier);

                    added++;
                }
            }

            return new Tuple<int>(added);
        }

        public Tuple<int> SendOrders(repositories.Order orders)
        {
            int counter = 0;

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM order_list WHERE cancel_at IS NULL AND (dvizh_id = 0 OR dvizh_id IS NULL) ORDER BY id DESC", db.connection);

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    entities.Order order = DataMapper.BuildOrder(reader);
                    int dvizhid = SendOrder(order);
                    if(dvizhid > 0)
                    {
                        orders.SaveDvizhIdWithSql(order, dvizhid);
                        counter++;
                    }
                }
            }

            reader.Close();

            return new Tuple<int>(counter);
        }

        //return dvizh_id
        public int SendOrder(entities.Order order)
        {
            string ids = "";

            foreach(entities.OrderElement element in order.GetElements())
            {
                ids += element.GetProductId().ToString() + "|" + element.GetCount() + "|" + element.GetPrice() + ";";
            }

            string url =
                Properties.Settings.Default.protocol
                + "://"
                + Properties.Settings.Default.client
                + "."
                + Properties.Settings.Default.host
                + "/"
                + Properties.Settings.Default.csvRestPath
                + "/order"
                + Properties.Settings.Default.tokenPrefix
                + "token="
                + Properties.Settings.Default.token
                + "&ids="
                + ids
                + "&cost="
                + order.GetTotal().ToString()
                 + "&date="
                + order.GetDate()
                + "&promocodeId="
                + order.GetDiscountId().ToString()
                + "&cashierId="
                + order.GetCashierId().ToString()
                + "&clientId="
                + order.GetClientId().ToString();

            try
            {
                string result = new WebClient().DownloadString(url);

                return Convert.ToInt32(result);
            }
            catch (System.Net.WebException e)
            {
                MessageBox.Show(e.Message);

                return 0;
            }
        }

        public string GetCsvString(string action = "index")
        {
            string url =
                Properties.Settings.Default.protocol
                + "://"
                + Properties.Settings.Default.client
                + "."
                + Properties.Settings.Default.host
                + "/"
                + Properties.Settings.Default.csvRestPath
                + "/"
                + action
                + Properties.Settings.Default.tokenPrefix
                + "token="
                + Properties.Settings.Default.token;
            //Clipboard.SetText(url);
            try
            {
                string csv = new WebClient().DownloadString(url);

                return csv;
            }
            catch(System.Net.WebException e)
            {
                MessageBox.Show(e.Message);

                return "";
            }
        }

        public List<string[]> ParseCsv(string csv)
        {
            List<string[]> lines = new List<string[]>();

            if (csv == "")
                return lines;

            char lineDelimiter = '\n';
            char cellDelimiter = ';';

            String[] stringLines = csv.Split(lineDelimiter);

            foreach(string rowString in stringLines)
            {
                String[] stringCells = rowString.Split(cellDelimiter);
                lines.Add(stringCells);
            }

            return lines;
        }
    }
}
