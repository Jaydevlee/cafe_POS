using Cafe_Pos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Pos.Forms
{
    public partial class Form_Recipt : Form
    {
        long orderId;
        string textTotal = "";
        string textCharge = "";
        string textRecevied = "";

        private Dictionary<string, OrderItems> orderList = new Dictionary<string, OrderItems>();
        private List<Orders> orders = new List<Orders>();

        public Form_Recipt(long orderId, List<Orders> orders, Dictionary<string, OrderItems> orderList)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.orders = orders;
            this.orderList = orderList;
        }


        private void LoadOrderList()
        {
            foreach(OrderItems order in orderList.Values)
            {
                lstOrderList.Items.Add($"{order.Menu_name} {order.Quantity} {order.Subtotal}");
            }
        }

        private void LoadPrice()
        {
            int total = orders[0].Total_amount;
            int charge = orders[0].Change_amount;
            int received = orders[0].Received_amount;
            lblTotal.Text += $" {}"
        }
    }
}
