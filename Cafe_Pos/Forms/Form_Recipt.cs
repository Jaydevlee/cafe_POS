using Cafe_Pos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Pos.Forms
{
    public partial class Form_Recipt : Form
    {
        long orderId;
        string textTotal = "";
        string textCharge = "";
        string textReceived = "";

        private Dictionary<string, OrderItems> orderList = new Dictionary<string, OrderItems>();
        private List<Orders> orders = new List<Orders>();

        public Form_Recipt(long orderId, List<Orders> orders, Dictionary<string, OrderItems> orderList)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.orders = orders;
            this.orderList = orderList;

            ReciptInit();
        }

        
        private void ReciptInit()
        {
            LoadOrderList();
            LoadAmount();
        }

        private void LoadOrderList()
        {
            foreach(OrderItems order in orderList.Values)
            {
                lstOrderList.Items.Add($"{order.Menu_name} {order.Quantity} {order.Subtotal}");
            }
        }


        private void LoadAmount()
        {
            LoadTotal();
            LoadCharge();
            LoadReceived();
        }

        private void LoadReceived()
        { 
            int received = orders[0].Received_amount;
            textReceived = received.ToString("N0");
            lblReceived.Text += $" {textReceived}원";
        }

        private void LoadTotal()
        {
            int total = orders[0].Total_amount;
            textTotal = total.ToString("N0");
            lblTotal.Text += $" {textTotal}원";
        }

        private void LoadCharge()
        {
            int charge = orders[0].Change_amount;
            textCharge = charge.ToString("N0");
            lblCharge.Text += $" {textCharge}원";
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
            lstOrderList.Items.Clear();
            orderList.Clear();
            orders.Clear();
        }
    }
}
