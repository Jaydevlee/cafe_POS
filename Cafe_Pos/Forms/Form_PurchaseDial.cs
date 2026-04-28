using Cafe_Pos.Models;
using Cafe_Pos.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Pos.Forms
{
    public partial class Form_PurchaseDial : Form
    {
        private Dictionary<string, OrderItems> OrderList = new Dictionary<string, OrderItems>();
        private List<Orders> orders = new List<Orders>();
        private OrderRepostiory orderRepostiory = new OrderRepostiory();

        private int total { get; set; }
        private int recived_amount { get; set; }
        private int charge { get; set; }
        public Form_PurchaseDial(Dictionary<string, OrderItems> OrderList)
        {
            InitializeComponent();
            this.OrderList = OrderList;
            btnRecivedEvent();
            LoadOrderList();
            CalcTotal();
            Calc_Charge();
        }

        private void LoadOrderList()
        {
            lstOrder.Items.Clear();
            foreach (OrderItems o in OrderList.Values)
            {
                lstOrder.Items.Add($"{o.Menu_name} {o.Quantity} {o.Subtotal}");
            }
        }
        private void CalcTotal()
        {
            int priceNum = 0;
            foreach (OrderItems o in OrderList.Values)
            {
                priceNum += o.Subtotal;
            }
            total = priceNum;
            displayTotal.Text = total.ToString() + "원";
        }

        // 받은 금액 이벤트
        private void btnRecivedEvent()
        {
            btn10.Click += btn10_Click;
            btn5.Click += btn5_Click;
            btn1.Click += btn1_Click;
            btnPrice.Click += btnPrice_Click;
            btnClear.Click += btnClear_Click;
        }

        private void btn10_Click(object? sender, EventArgs e)
        {
            Calc_Recived(10000);
        }
        private void btn5_Click(object? sender, EventArgs e)
        {
            Calc_Recived(5000);
        }

        private void btn1_Click(object? sender, EventArgs e)
        {
            Calc_Recived(1000);
        }
        private void btnPrice_Click(object? sender, EventArgs e)
        {
            int result = total;
            recived_amount = result;
            textRecived.Text = result.ToString();
            Calc_Charge();
        }
        private void btnClear_Click(object? sender, EventArgs e)
        {
            textRecived.Text = "";
            Calc_Charge();
        }

        private void Calc_Recived(int num)
        {
            int result;
            if (textRecived.Text == "")
            {
                result = num;
            }
            else
            {
                result = int.Parse(textRecived.Text) + num;
            }

            recived_amount = result;
            textRecived.Text = result.ToString();
            Calc_Charge();
        }

        // 거스름 돈 계산
        private void Calc_Charge()
        {
            if (textRecived.Text.Equals(""))
            {
                displayCharge.Text = "0원";
            }
            else
            {
                charge = recived_amount - total;
                displayCharge.Text = charge.ToString() + "원";
            }

        }

        private void textRecived_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) PressNumber("0");
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) PressNumber("1");
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) PressNumber("2");
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) PressNumber("3");
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) PressNumber("4");
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) PressNumber("5");
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) PressNumber("6");
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) PressNumber("7");
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) PressNumber("8");
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) PressNumber("9");
            else if (e.KeyCode == Keys.Back) PressBackSpace();
            else if (e.KeyCode == Keys.Escape) Reset();
        }

        private void PressNumber(string digit)
        {
            string currentValue = textRecived.Text;
            if (currentValue == "0")
            {
                currentValue = "digit";
            }
            else
            {
                currentValue += digit;
                recived_amount = int.Parse(currentValue);
            }
            Calc_Charge();
        }

        private void PressBackSpace()
        {
            string currentValue = textRecived.Text;
            if (currentValue == "" || currentValue.Length < 1) currentValue = "";
            else currentValue.Substring(0, currentValue.Length - 1);
        }

        private void Reset()
        {
            textRecived.Text = "0";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            
            orders.Clear();
            orders.Add(new Orders
            {
                Total_amount = total,
                Change_amount = charge,
                Received_amount = recived_amount
            });

            long orderId = orderRepostiory.InsertOrder(OrderList, orders);
            Form_Recipt form = new Form_Recipt(orderId, orders, OrderList);
            form.ShowDialog();            
        }
    }
}
