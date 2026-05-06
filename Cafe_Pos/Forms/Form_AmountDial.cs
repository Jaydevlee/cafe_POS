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
        private void btnUp_Click(object? sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            quantity++;
            lblQuantity.Text = quantity.ToString();
        }

        private void btnDown_Click(object? sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            quantity--;
            if (quantity < 0)
            {
                return;
            }
            lblQuantity.Text = quantity.ToString();

            if(lblQuantity.Text == "0")
            {
                OrderList.Remove(menuName);
                this.Close();
            }
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

        private void ApplyModernDesign()
        {
            this.BackColor = Color.FromArgb(245, 245, 245); // 전체 배경색 연한 회색

            // 텍스트 설정
            lblMenu.ForeColor = Color.FromArgb(62, 39, 35); // 짙은 갈색
            lblMenu.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);

            // 수량 라벨(또는 텍스트박스) 
            lblQuantity.BackColor = Color.White;
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Font = new Font("맑은 고딕", 24F, FontStyle.Bold);
            // lblQuantity.BorderStyle = BorderStyle.FixedSingle; // 라벨인 경우 주석 해제

            // -, + 버튼 디자인 
            Button[] qtyButtons = { btnUp, btnDown };
            foreach (Button btn in qtyButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(180, 170, 160);
                btn.BackColor = Color.FromArgb(220, 210, 205);
                btn.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
                btn.ForeColor = Color.FromArgb(62, 39, 35);
                btn.Cursor = Cursors.Hand;
            }

            // 삭제 버튼 디자인
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.BackColor = Color.FromArgb(211, 47, 47);
            btnRemove.ForeColor = Color.White;
            btnRemove.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnRemove.Cursor = Cursors.Hand;

            // 확인 버튼 디자인
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor = Color.FromArgb(216, 67, 21);
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
        }
    }
}
