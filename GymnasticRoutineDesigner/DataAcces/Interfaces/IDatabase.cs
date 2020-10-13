using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface IDatabase
    {
        MySqlConnection GetConnection();
    }
}
