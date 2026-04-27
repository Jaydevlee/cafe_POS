using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Pos.Data
{
    public static class DBHepler
    {
        public static string ConnectionString =
               "Server = localhost;" +
                "Port=3306;" +
                "Database=cafe_pos;" +
                "Uid=root;" +
                "Pwd=1234;" +
                "Charset=utf8mb4;";

        public static MySqlConnection GetConnection()
        { 
            return new MySqlConnection(ConnectionString); 
        }
    }
}
