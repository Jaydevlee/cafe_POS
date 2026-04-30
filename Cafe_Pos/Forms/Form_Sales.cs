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
    public partial class Form_Sales : Form
    {
        private OrderRepostiory orderRepository = new();

        private List<OrderTop5> list = new List<OrderTop5>();
        public Form_Sales()
        {
            InitializeComponent();
            PageInit();
            
        }

        //private void btnSelect_Click(object? sender, EventArgs e)
        //{
        //    ShowDateTimePick();
        //}

        private void PageInit()
        {
            int lastDay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, lastDay);
            string dateTime1 = dtpStart.Value.ToString("yyyy-MM-dd");
            string dateTime2 = dtpEnd.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(dateTime1);
            MessageBox.Show(dateTime2);
            SelectTotal_Amount(dateTime1, dateTime2);
            SelectOrders_Amount(dateTime1, dateTime2);
            SelectAvg_Amount(dateTime1, dateTime2);
            btnSelect.Click += btnSelect_Click;
        }

        

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            LoadSales();
        }

        private void LoadSales()
        {
            string dateTime1 = dtpStart.Value.ToString("yyyy-MM-dd");
            string dateTime2 = dtpEnd.Value.ToString("yyyy-MM-dd");
            SelectTotal_Amount(dateTime1, dateTime2);
            SelectOrders_Amount(dateTime1, dateTime2);
            SelectAvg_Amount(dateTime1, dateTime2);
            LoadTop5(dateTime1, dateTime2);
        }

        private void SelectTotal_Amount(string dateTime1, string dateTime2)
        {   
            int result = orderRepository.SelectTotal_Amount(dateTime1, dateTime2);
            string total_amount = result.ToString("N0");
            displayTotal.Text = $"{total_amount}원";
        }

        private void SelectOrders_Amount(string dateTime1, string dateTime2)
        {
            int result = orderRepository.SelectOrders_Amount(dateTime1, dateTime2);
            string orders_amount = result.ToString("N0");
            displayOrders.Text = $"{orders_amount}건";
        }

        private void SelectAvg_Amount(string dateTime1, string dateTime2)
        {
            int result = orderRepository.SelectAvg_Amount(dateTime1, dateTime2);
            string avg_amount = result.ToString("N0");
            displayAvg.Text = $"{avg_amount}원";
        }

        private void LoadTop5(string dateTime1, string dateTime2)
        {
            list = orderRepository.SelectOrderTop5(dateTime1, dateTime2);
            dsTop5.DataSource = list;
            dgvTop5.DataSource = list;
        }
    }
}
