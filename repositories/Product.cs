using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DvizhSeller.repositories
{
    class Product
    {
        private List<entities.Product> products = new List<entities.Product>();

        services.Database db;

        public Product(services.Database setDb)
        {
            db = setDb;
        }

        public void Add(entities.Product product)
        {
            products.Add(product);
        }

        public int SaveWithSql(entities.Product product)
        {
            entities.Product hasProduct = FindOne(product.GetId());

            SQLiteCommand command;

            if (product.GetId() == 0 | hasProduct == null)
            { 
                Add(product);
                
                command = new SQLiteCommand("INSERT INTO product(sku, name, price, category_id, image, amount) VALUES(@sku, @name, @price, @category_id, @image, @amount)", db.connection);
            }
            else
            {
                command = new SQLiteCommand("UPDATE product SET sku = @sku, name = @name, price = @price, category_id = @category_id, image = @image, amount = @amount WHERE id = @id ", db.connection);
            }

            command.Parameters.AddWithValue("@id", product.GetId());
            command.Parameters.AddWithValue("@sku", product.GetSku());
            command.Parameters.AddWithValue("@name", product.GetName());
            command.Parameters.AddWithValue("@price", Convert.ToDecimal(product.GetPrice()));
            command.Parameters.AddWithValue("@category_id", product.GetCategoryId());
            command.Parameters.AddWithValue("@image", product.GetImage());
            command.Parameters.AddWithValue("@amount", product.GetAmount());
            
            int num = command.ExecuteNonQuery();
            
            return num;
        }

        public int DeleteWithSql(entities.Product product)
        {
            entities.Product hasProduct = FindOne(product.GetId());

            SQLiteCommand command;

            command = new SQLiteCommand("DELETE FROM product WHERE id = @id", db.connection);

            command.Parameters.AddWithValue("@id", product.GetId());

            int num = command.ExecuteNonQuery();

            return num;
        }

        public void Delete(entities.Product product)
        {
            products.Remove(product);
        }

        public void Clear()
        {
            products.Clear();
        }

        public List<entities.Product> GetList()
        {
            return products;
        }

        public entities.Product FindOne(int id)
        {
            return products.Find(x => x.GetId() == id);
        }

        public List<entities.Product> FindByString(string str)
        {
            return products.FindAll(x => x.GetNameAndSku().ToLower().Contains(str.ToLower()));
        }

        public List<entities.Product> FindByCategory(entities.Category category)
        {
            return products.FindAll(x => x.GetCategoryId() == category.GetId());
        }

        public List<entities.Product> FindByCategoryId(int categoryId)
        {
            return products.FindAll(x => x.GetCategoryId() == categoryId);
        }

        public List<entities.Product> FindBySku(string sku)
        {
            return products.FindAll(x => x.GetSku() == sku);
        }

        public entities.Product FindOneBySku(string sku)
        {
            return products.Find(x => x.GetSku() == sku);
        }
    }
}
