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
        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;
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

        // 폼 최소화
        private void btnMin_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Button(object? sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
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
