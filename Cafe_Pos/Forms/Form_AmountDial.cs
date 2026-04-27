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
    
    public partial class Form_AmountDial : Form
    {
        private Dictionary<string, OrderItems> OrderList;
        private string menuName;
        public Form_AmountDial(string menuName, string quantity, Dictionary<string, OrderItems> OrderList)
        {
            InitializeComponent();
            this.menuName = menuName;
            this.OrderList = OrderList;
            lblMenu.Text = menuName;
            lblQuantity.Text = quantity;

            btnSave.Click += btnSave_Click;
            btnRemove.Click += btnRemove_Click;

        }

        private void btnUp_Click(object? sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            quantity++;
            lblQuantity.Text=quantity.ToString();
        }

        private void btnDown_Click(object? sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            quantity--;
            if (quantity < 1)
            {
                return;
            }
            lblQuantity.Text = quantity.ToString();          
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            OrderList[menuName].Quantity = int.Parse(lblQuantity.Text);
            OrderList[menuName].Subtotal = OrderList[menuName].Quantity * OrderList[menuName].Price;
            this.Close();
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            OrderList.Remove(menuName);
            this.Close();
        }
    }
}
