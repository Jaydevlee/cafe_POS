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
        Form_Main formMain = new Form_Main();

        private Dictionary<string, OrderItems> orderList = new Dictionary<string, OrderItems>();
        private List<Orders> orders = new List<Orders>();

        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;

        public Form_Recipt(long orderId, List<Orders> orders, Dictionary<string, OrderItems> orderList, Form_Main formMain)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.orders = orders;
            this.orderList = orderList;
            this.formMain = formMain;
            ReciptInit();
            btnClose.Click += btnClose_Click;
        }


        // 제목줄 마우스 좌클릭
        private void lblTitle_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLotion = e.Location;
            }
        }

        private void lblTitle_MouseUp(object? sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lblTitle_MouseMove(object? sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLotion.X) + e.X,
                    (this.Location.Y - lastLotion.Y) + e.Y);
                this.Update();
            }
        }

        private void btnFormClose_Clilck(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ReciptInit()
        {
            LoadOrderId();
            LoadDateTime();
            LoadOrderList();
            LoadAmount();
        }

        private void LoadOrderId()
        {
            lblOrderId.Text += $" #{orderId}";
        }

        private void LoadDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void LoadOrderList()
        {
            foreach (OrderItems order in orderList.Values)
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
            lstOrderList.Items.Clear();
            orderList.Clear();
            orders.Clear();
            this.Close();
            formMain.Form_Main_Clear();
        }
    }
}
