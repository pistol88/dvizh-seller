using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DvizhSeller.repositories
{
    class Client
    {
        private List<entities.Client> clients = new List<entities.Client>();

        services.Database db;

        public Client(services.Database setDb)
        {
            db = setDb;
        }
        
        public void Add(entities.Client client)
        {
            clients.Add(client);
        }

        public int SaveWithSql(entities.Client client)
        {
            entities.Client hasClient = FindOne(client.GetId());

            SQLiteCommand command;

            if (hasClient == null)
            {
                Add(client);
                command = new SQLiteCommand("INSERT INTO client(name, phone) VALUES(@name, @phone)", db.connection);
            }
            else
            {
                command = new SQLiteCommand("UPDATE client SET name = @name, phone = @phone WHERE id = @id ", db.connection);
            }

            command.Parameters.AddWithValue("@id", client.GetId());
            command.Parameters.AddWithValue("@name", client.GetName());
            command.Parameters.AddWithValue("@phone", client.GetPhone());

            int num = command.ExecuteNonQuery();

            return num;
        }

        public void Delete(entities.Client client)
        {
            clients.Remove(client);
        }

        public List<entities.Client> GetList()
        {
            return clients;
        }

        public entities.Client FindOne(int id)
        {
            return clients.Find(x => x.GetId() == id);
        }

        public List<entities.Client> FindByString(string str)
        {
            return clients.FindAll(x => x.GetNameAndPhone().Contains(str));
        }

        public List<entities.Client> FindByName(string name)
        {
            return clients.FindAll(x => x.GetName().Contains(name));
        }

        public List<entities.Client> FindByPhone(string name)
        {
            return clients.FindAll(x => x.GetPhone().Contains(name));
        }
    }
}
