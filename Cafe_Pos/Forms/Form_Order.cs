using Cafe_Pos.Data;
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
    public partial class Form_Order : Form
    {
        long id = 0;
        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;
        private List<Orders> list = new List<Orders> ();
        private List<OrderItems> listItem = new List<OrderItems> ();
        private OrderRepostiory orderRepostiory = new OrderRepostiory();
        public Form_Order()
        {
            InitializeComponent();
            PageInit();
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

        private void PageInit()
        {
            LoadOrders();
            dgvOrders.SelectionChanged += dgvOrdres_SelectionChanged;
        }

        private void LoadOrders()
        {
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            string dateTime1 = today.ToString("yyyy-MM-dd");
            DateTime tomorrow = today.AddDays(1);
            string dateTime2 = tomorrow.ToString("yyyy-MM-dd");
            list = orderRepostiory.SelectTodayOrders(dateTime1, dateTime2);
            
            dsOrders.DataSource = list;
            dgvOrders.DataSource = dsOrders;
        }

        private void dgvOrdres_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0) getOrderId();
        }

        private void getOrderId()
        {
            DataGridViewRow row = dgvOrders.SelectedRows[0];
            id = long.Parse(row.Cells["Id"].Value.ToString());
            LoadOrderItem(id);
        }

        private void LoadOrderItem(long id)
        {
            listItem = orderRepostiory.SelectOrderITemById(id);
            dsOrderItems.DataSource = listItem;
            dgvOrderItem.DataSource = dsOrderItems;
        }
    }
}
