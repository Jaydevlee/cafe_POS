using Cafe_Pos.Models;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using MenuItem = Cafe_Pos.Models.MenuItem;

namespace Cafe_Pos.Data
{
    public class OrderRepostiory
    {
        // 주문 넣기
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

        public int SelectTotal_Amount(string dateTime1, string dateTime2)
        {
            int total_amount = 0;
            using (MySqlConnection conn = DBHepler.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT SUM(total_amount) AS total_amount " +
                                 "FROM orders " +
                                 "WHERE ORDER_DATE BETWEEN @dateTime1 AND DATE_ADD(@dateTime2, interval 1 DAY)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("dateTime1", dateTime1);
                        cmd.Parameters.AddWithValue("dateTime2", dateTime2);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                total_amount = reader.GetInt32("total_amount");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("매출정보를 가져오지 못했습니다. " + e.Message);
                }

            }
            return total_amount;
        }

        public int SelectOrders_Amount(string dateTime1, string dateTime2)
        {
            int orders_amount = 0;
            using (MySqlConnection conn = DBHepler.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) AS orders_amount " +
                                 "FROM orders " +
                                 "WHERE ORDER_DATE BETWEEN @dateTime1 AND DATE_ADD(@dateTime2, interval 1 DAY)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("dateTime1", dateTime1);
                        cmd.Parameters.AddWithValue("dateTime2", dateTime2);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orders_amount = reader.GetInt32("orders_amount");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("매출정보를 가져오지 못했습니다. " + e.Message);
                }
            }
            return orders_amount;
        }

        public int SelectAvg_Amount(string dateTime1, string dateTime2)
        {
            int avg_amount = 0;
            using (MySqlConnection conn = DBHepler.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT AVG(total_amount) AS avg_amount " +
                                 "FROM orders " +
                                 "WHERE ORDER_DATE BETWEEN @dateTime1 AND DATE_ADD(@dateTime2, interval 1 DAY)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("dateTime1", dateTime1);
                        cmd.Parameters.AddWithValue("dateTime2", dateTime2);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                avg_amount = reader.GetInt32("avg_amount");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("매출정보를 가져오지 못했습니다. " + e.Message);
                }
            }
            return avg_amount;
        }

        public List<OrderTop5> SelectOrderTop5(string dateTime1, string dateTime2)
        {
            List<OrderTop5> orderTop5 = new List<OrderTop5>();
            using (MySqlConnection conn = DBHepler.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT menu_name, 
		                            SUM(oi.quantity) as 판매량, 
		                            SUM(oi.subtotal) as 매출, 
		                            ROUND(sum(oi.SUBTOTAL)/
		                            (SELECT SUM(total_amount) FROM orders WHERE ORDER_DATE BETWEEN @dateTime1 AND DATE_ADD(@dateTime2, interval 1 DAY))*100, 2) as 비중
	                             FROM ORDER_ITEMS oi
	                             INNER JOIN ORDERS o
	                             ON oi.ORDER_ID  = o.ID
	                             WHERE o.ORDER_DATE  BETWEEN @dateTime1 AND DATE_ADD(@dateTime2, interval 1 DAY)
                                 GROUP BY menu_name
                                 ORDER BY SUM(oi.quantity) desc
                                 LIMIT 5";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("dateTime1", dateTime1);
                        cmd.Parameters.AddWithValue("dateTime2", dateTime2);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrderTop5 items = new OrderTop5()
                                {
                                    name = reader.GetString("menu_name"),
                                    quantity = reader.GetInt32("판매량"),
                                    subtotal = reader.GetInt32("매출"),
                                    ratio = reader.GetDouble("비중")
                                };
                                orderTop5.Add(items);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("매출정보를 가져오지 못했습니다. " + e.Message);
                }
            }
            return orderTop5;
        }
    }
}
