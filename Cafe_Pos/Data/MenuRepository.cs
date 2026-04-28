using Cafe_Pos.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using MenuItem = Cafe_Pos.Models.MenuItem;

namespace Cafe_Pos.Data
{
    public class MenuRepository
    {
        public List<MenuItem> SelectMenu(string text) {
            List<MenuItem> list = new List<MenuItem>();
            try 
            {
                using MySqlConnection conn = DBHepler.GetConnection();
                {
                    conn.Open();
                    string sql = "SELECT id, name, price, category FROM menu " +
                                  "WHERE category = @category " +
                                  "AND is_active = 1";
                    using MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@category", text);
                    using MySqlDataReader reader = cmd.ExecuteReader();

                    {

                        while (reader.Read())
                        {
                            MenuItem item = new()
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name"),
                                Category = reader.GetString("category"),
                                Price = reader.GetInt32("price")
                            };
                            list.Add(item);
                        }                       
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show("DB 연결 실패: " + ex.Message);
            }
            return list;          
        }

        public List<String> SelectCategory()
        {
            List<string> list = new List<string>();
            try
            {
                using MySqlConnection conn = DBHepler.GetConnection();
                {
                    conn.Open();
                    string sql = "SELECT category FROM MENU";
                    using MySqlCommand cmd = new MySqlCommand(sql, conn);
                    using MySqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            string category = reader.GetString("category");
                            if(!list.Contains(category)) 
                            {
                                list.Add(category);
                            }                        
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB연결실패" + ex.Message);
            }
            return list;
        }

        //public List<int> SelectIsActive()
        //{
        //    List<int> list = new List<int>();
        //    try
        //    {
        //        using MySqlConnection conn = DBHepler.GetConnection();
        //        {
        //            conn.Open();
        //            string sql = "SELECT is_active FROM MENU";
        //            using MySqlCommand cmd = new MySqlCommand(sql, conn);
        //            using MySqlDataReader reader = cmd.ExecuteReader();
        //            {
        //                while (reader.Read())
        //                {
        //                    int isActive = reader.GetInt32("is_active");
        //                    if (!list.Contains(isActive))
        //                    {
        //                        list.Add(isActive);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("DB연결실패" + ex.Message);
        //    }
        //    return list;
        //}

        public List<MenuItem> SelectAllMenu()
        {
            List<MenuItem> List = new List<MenuItem>();
            try
            {
                using (MySqlConnection conn = DBHepler.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT id, name, category, price, is_active
                                    FROM MENU";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader read = cmd.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                {
                                    MenuItem item = new MenuItem
                                    {
                                        Id = read.GetInt32("id"),
                                        Name = read.GetString("name"),
                                        Category = read.GetString("category"),
                                        Price = read.GetInt32("price"),
                                        Is_active = read.GetInt32("is_active")
                                    };
                                    List.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB연결실패: {ex.Message}");
            }
            return List;
        }
    }
}
