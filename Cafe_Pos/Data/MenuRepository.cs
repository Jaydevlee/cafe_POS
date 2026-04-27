using Cafe_Pos.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
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
        
        //public List<MenuItem> SelectCategory()
        //{
        //    List<MenuItem> list = new List<MenuItem>();
        //    try
        //    {
        //        using MySqlConnection conn = DBHepler.GetConnection();
        //        {
        //            conn.Open();
        //            string sql = "SELECT category FROM MENU";
        //            using MySqlCommand cmd = new MySqlCommand(sql, conn);
        //            using MySqlDataReader reader = cmd.ExecuteReader();
        //            {
        //                while (reader.Read())
        //                {
        //                    MenuItem category = new()
        //                    {
        //                        Category = reader.GetString("category");
        //                    };
        //                    list.Add(category);
        //                }
        //            }
        //        }
        //    } catch (Exception ex)
        //    {
        //        MessageBox.Show("DB연결실패" + ex.Message);
        //    }
        //    return list;
        //}
    }
}
