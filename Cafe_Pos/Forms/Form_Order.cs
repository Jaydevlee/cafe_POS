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
        private List<Orders> list = new List<Orders>();
        private List<OrderItems> listItem = new List<OrderItems>();
        private OrderRepostiory orderRepostiory = new OrderRepostiory();
        public Form_Order()
        {
            InitializeComponent();
            PageInit();
            ApplyModernDesign();
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
            if(list.Count == 0)
            {
                MessageBox.Show("오늘 주문이 없습니다.");
            }
            dsOrders.DataSource = list;
            dgvOrders.DataSource = dsOrders;

            dgvOrders.Columns["Id"].HeaderText = "주문번호";
            dgvOrders.Columns["Order_date"].HeaderText = "주문일자";
            dgvOrders.Columns["Total_amount"].HeaderText = "총 금액";
            dgvOrders.Columns["Received_amount"].HeaderText = "받은 금액";
            dgvOrders.Columns["Change_amount"].HeaderText = "거스름돈";

            dgvOrders.Columns["Id"].Width = 80;
            dgvOrders.Columns["Order_date"].Width = 250;
            dgvOrders.Columns["Total_amount"].Width = 150;
            dgvOrders.Columns["Received_amount"].Width = 150;
            dgvOrders.Columns["Change_amount"].Width = 150;
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

            dgvOrderItem.Columns["Order_id"].HeaderText = "주문번호";
            dgvOrderItem.Columns["Menu_id"].HeaderText = "메뉴번호";
            dgvOrderItem.Columns["Menu_name"].HeaderText = "메뉴";
            dgvOrderItem.Columns["Price"].HeaderText = "가격";
            dgvOrderItem.Columns["Quantity"].HeaderText = "수량";
            dgvOrderItem.Columns["SubTotal"].HeaderText = "총합";

            dgvOrderItem.Columns["Id"].Width = 80;
        }

        private void ApplyModernDesign()
        {
            // 1. 폼 전체 배경색 (연한 회색/베이지)
            this.BackColor = Color.FromArgb(248, 248, 248);

            // 2. 컨트롤 디자인 일괄 탐색 및 적용
            ApplyStyleToAllControls(this);
        }

        private void ApplyStyleToAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // 1. DataGridView 디자인 (핵심)
                if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.FixedSingle;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                    // 헤더 스타일
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(90, 61, 49);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
                    dgv.ColumnHeadersHeight = 40;

                    // 행(Row) 스타일 
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = Color.Black;
                    dgv.DefaultCellStyle.Font = new Font("맑은 고딕", 10F);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 224, 180);
                    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dgv.RowTemplate.Height = 35;

                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.AllowUserToAddRows = false;
                    dgv.RowHeadersVisible = false; 
                }
                // 2. 상단 우측 창 조절 버튼 
                else if (ctrl is Button btn && (btn.Text == "-" || btn.Text == "ㅁ" || btn.Text == "□" || btn.Text.ToUpper() == "X"))
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(93, 55, 55);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }
                // 3. 라벨 디자인
                else if (ctrl is Label lbl)
                {
                    // 상단 타이틀 ("커피한잔 POS - 주문관리")
                    if (lbl.Text.Contains("주문관리"))
                    {
                        lbl.ForeColor = Color.White;
                        lbl.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);

                       
                        if (lbl.Parent is Panel pnl)
                            pnl.BackColor = Color.FromArgb(90, 61, 49);
                    }
                    
                    else if (lbl.Text == "주문내역" || lbl.Text == "주문상세")
                    {
                        lbl.ForeColor = Color.FromArgb(62, 39, 35);
                        lbl.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
                    }
                }

                // 패널 안에 있는 컨트롤들도 놓치지 않고 탐색
                if (ctrl.HasChildren)
                {
                    ApplyStyleToAllControls(ctrl);
                }
            }
        }
    }
}
