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
        Form_Main formMain = new Form_Main();

        private int total { get; set; }
        private int recived_amount { get; set; }
        private int charge { get; set; }

        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;

        public Form_PurchaseDial(Dictionary<string, OrderItems> OrderList)
        {
            InitializeComponent();
            this.OrderList = OrderList;
            //this.formMain = formMain;
            btnRecivedEvent();
            LoadOrderList();
            CalcTotal();
            Calc_Charge();
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

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
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
            if (currentValue == "")
            {
                currentValue = digit;
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
            else currentValue = currentValue.Substring(0, currentValue.Length - 1);
        }

        private void Reset()
        {
            textRecived.Text = "0";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (recived_amount < total)
            {
                MessageBox.Show("금액이 부족합니다.");
                return;
            }
            if(!int.TryParse(textRecived.Text, out int result))
            {
                MessageBox.Show("숫자만 입력해주세요");
                return;
            }

            orders.Clear();
            orders.Add(new Orders
            {
                Total_amount = total,
                Change_amount = charge,
                Received_amount = recived_amount
            });

            using (Form_Points formPoints = new Form_Points())
            {
                if (formPoints.ShowDialog() == DialogResult.OK)
                {
                    bool addPoints = formPoints.isPointsAdded;
                    string phone = formPoints.phone;

                    if(addPoints)
                    {
                        Member member = new Member
                        {
                            phone = phone,
                            addPoints = total * 5 / 100
                        };
                        orderRepostiory.UpdatePoints(member);
                    } 
                    long orderId = orderRepostiory.InsertOrder(OrderList, orders);

                    using (Form_Recipt form = new Form_Recipt(orderId, orders, OrderList))
                    {
                        if(form.ShowDialog() == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
        }

        private void ApplyModernDesign()
        {
            // 1. 폼 전체 배경색 설정 (연한 회색)
            this.BackColor = Color.FromArgb(245, 245, 245);

            // 2. 상단 타이틀 바 설정
            tlpMainTitle.BackColor = Color.FromArgb(90, 61, 49); // 짙은 갈색
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);

            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.BackColor = Color.FromArgb(90, 61, 49);
            btnClose.ForeColor = Color.White;
            btnClose.Cursor = Cursors.Hand;

            // 3. 공통 라벨 폰트 및 색상
            Font labelFont = new Font("맑은 고딕", 11F, FontStyle.Bold);
            Color darkBrown = Color.FromArgb(62, 39, 35);

            lblOrder.Font = labelFont; lblOrder.ForeColor = darkBrown;
            lblTotal.Font = labelFont; lblTotal.ForeColor = darkBrown;
            lblRecived.Font = labelFont; lblRecived.ForeColor = darkBrown;
            lblCharge.Font = labelFont; lblCharge.ForeColor = darkBrown;
            label1.Font = labelFont; label1.ForeColor = darkBrown; // '원' 글자

            // 4. 주문 리스트 박스
            lstOrder.Font = new Font("맑은 고딕", 11F);
            lstOrder.BorderStyle = BorderStyle.FixedSingle;

            // 5. 결제 금액 패널 및 금액 표시
            pnPrice.BackColor = Color.FromArgb(253, 235, 228);
            pnPrice.BorderStyle = BorderStyle.FixedSingle;

            displayTotal.ForeColor = Color.FromArgb(215, 65, 25); // 진한 주황/빨강
            displayTotal.Font = new Font("맑은 고딕", 22F, FontStyle.Bold);

            // 6. 받은 금액 텍스트박스
            textRecived.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            textRecived.BorderStyle = BorderStyle.FixedSingle;

            // 7. 금액 조작 버튼들 (+1만, +5천 등)
            Button[] moneyBtns = { btn10, btn5, btn1, btnPrice, btnClear };
            foreach (Button btn in moneyBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(180, 170, 160); 
                btn.BackColor = Color.FromArgb(220, 210, 205); // 베이지색 바탕
                btn.ForeColor = darkBrown;
                btn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
            }

            // 8. 거스름돈 표시
            displayCharge.ForeColor = Color.FromArgb(67, 160, 71); 
            displayCharge.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);

            // 9. 하단 취소 / 결제 완료 버튼
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(180, 170, 160);
            btnCancel.BackColor = Color.FromArgb(220, 210, 205);
            btnCancel.ForeColor = darkBrown;
            btnCancel.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            btnCancel.Cursor = Cursors.Hand;

            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.BackColor = Color.FromArgb(215, 65, 25); 
            btnPayment.ForeColor = Color.White;
            btnPayment.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            btnPayment.Cursor = Cursors.Hand;
        }
    }
}
