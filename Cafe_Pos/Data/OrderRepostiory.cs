using Cafe_Pos.Models;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using MenuItem = Cafe_Pos.Models.MenuItem;

namespace Cafe_Pos.Data
{
    public class OrderRepostiory
    {
        public long InsertOrder(Dictionary<string, OrderItems> OrderList, List<Orders> orders)
        {
            long orderId = 0;
            
            using MySqlConnection conn = DBHepler.GetConnection();
            {
                conn.Open();
                using var tx = conn.BeginTransaction();
                try
                {
                    // ORDERS INSERT
                    string sql1 = @"INSERT INTO orders(order_date, total_amount, received_amount, change_amount) 
                                    VALUES (NOW(), @total_amount, @received_amount, @chage_amount);
                                    SELECT LAST_INSERT_ID()";
                    using MySqlCommand cmd1 = new MySqlCommand(sql1, conn, tx);
                    cmd1.Parameters.AddWithValue("@Total_amount", orders[0].Total_amount);
                    cmd1.Parameters.AddWithValue("@received_amount", orders[0].Received_amount);
                    cmd1.Parameters.AddWithValue("@chage_amount", orders[0].Change_amount);
                    orderId = Convert.ToInt64(cmd1.ExecuteScalar());

                    string sql2 = @"INSERT INTO order_items (order_id, menu_id, menu_name, price, quantity, subtotal)
                                    VALUES (@oid, @mid, @menu_name, @price, @quantity, @subtotal)";
                    //using MySqlCommand cmd2 = new MySqlCommand(sql2, conn, tx);
                    foreach (OrderItems order in OrderList.Values)
                    {
                        using MySqlCommand cmd2 = new MySqlCommand(sql2, conn, tx);
                        cmd2.Parameters.AddWithValue("@oid", orderId);
                        cmd2.Parameters.AddWithValue("@mid", order.Menu_id);
                        cmd2.Parameters.AddWithValue("@menu_name", order.Menu_name);
                        cmd2.Parameters.AddWithValue("@price", order.Price);
                        cmd2.Parameters.AddWithValue("@quantity", order.Quantity);
                        cmd2.Parameters.AddWithValue("@subtotal", order.Subtotal);
                        cmd2.ExecuteNonQuery();
                        
                    }
                    MessageBox.Show("주문이 완료되었습니다.");
                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
                return orderId;
            }
        }
    }
}
