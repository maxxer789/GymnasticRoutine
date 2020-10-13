using System;
using System.Collections.Generic;
using System.Text;
using DataAcces.Interfaces;
using MySql.Data.MySqlClient;

namespace DataAcces
{
    public class Database : IDatabase
    {

        private MySqlConnection connection;
        public Database(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
