using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DvizhSeller.services
{
    class Database
    {
        string dbConnectionString = "Data Source=" + Properties.Settings.Default.dbFile + "; Version=3;";
        public SQLiteConnection connection;

        public Database()
        {
            connection = new SQLiteConnection(dbConnectionString);
            connection.Open();
        }
    }
}
