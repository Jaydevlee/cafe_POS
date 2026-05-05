using Cafe_Pos.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Cafe_Pos.Data
{
    public static class DBHepler
    {
        static string result = null;
        static DbConnect dbConnect = new DbConnect();
        public static string ConnectionString = null;

        static DBHepler()
        {
            findConfig();
        }
        private static void findConfig()
        {
            if (File.Exists("config.json"))
            {
                dbConnect = JsonSerializer.Deserialize<DbConnect>(File.ReadAllText("config.json"));
                ConnectionString += $"Server={dbConnect.Server};" +
                                    $"Port={dbConnect.Port};" +
                                    $"Database={dbConnect.Database};" +
                                    $"Uid={dbConnect.Uid};" +
                                    $"Pwd={dbConnect.Pwd};" +
                                    $"Charset={dbConnect.Charset};";
            }
            else
            {
                string server = Console.ReadLine();
                string port = Console.ReadLine();
                string database = Console.ReadLine();
                string uid = Console.ReadLine();
                string pwd = Console.ReadLine();
                string charset = Console.ReadLine();
                dbConnect = new DbConnect
                {
                    Server = server,
                    Port = port,
                    Database = database,
                    Uid = uid,
                    Pwd = pwd,
                    Charset = charset
                };
                File.WriteAllText("config.json", JsonSerializer.Serialize(dbConnect));
                findConfig();
            }
        }
        

        public static MySqlConnection GetConnection()
        { 
            return new MySqlConnection(ConnectionString); 
        }
    }
}
