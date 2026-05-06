using Cafe_Pos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static Cafe_Pos.Forms.Form_Recipt;

namespace Cafe_Pos.Forms
{
    public partial class Form_Recipt : Form
    {
        long orderId;
        string textTotal = "";
        string textCharge = "";
        string textReceived = "";
        private Font printFont;
        private StreamReader streamToPrint;

        Form_Main formMain = new Form_Main();

        private Dictionary<string, OrderItems> orderList = new Dictionary<string, OrderItems>();
        private List<Orders> orders = new List<Orders>();

        // 창닫기 후 폼 새로고침 이벤트
        public delegate void FormRefreshHandler(bool closeForm);
        public event FormRefreshHandler OnComplete;

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
            btnPrint.Click += btnPrint_Click;
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

            //delegate활용
            OnComplete(true);
        }

        private void btnPrint_Click(object? sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            pd.Print();
        }

        private void PrintPage(object? sender, PrintPageEventArgs ev)
        {
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            float leftMargin = ev.MarginBounds.Left;
            float yPos = ev.MarginBounds.Top;
            float lineHeight = normalFont.GetHeight(ev.Graphics);

            // 가게명
            ev.Graphics.DrawString(lblTitle.Text, titleFont, Brushes.Black, leftMargin, yPos);
            yPos += titleFont.GetHeight(ev.Graphics) + 10;

            // 날짜
            ev.Graphics.DrawString(lblDateTime.Text, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 5;

            // 구분선
            ev.Graphics.DrawLine(Pens.Black, leftMargin, yPos, ev.MarginBounds.Right, yPos);
            yPos += 10;

            // 주문 목록
            foreach (var item in lstOrderList.Items)
            {
                ev.Graphics.DrawString(item.ToString(), normalFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight + 3;
            }

            // 구분선
            ev.Graphics.DrawLine(Pens.Black, leftMargin, yPos, ev.MarginBounds.Right, yPos);
            yPos += 10;

            // 합계 / 받은금액 / 거스름돈
            ev.Graphics.DrawString(lblTotal.Text, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 3;
            ev.Graphics.DrawString(lblReceived.Text, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 3;
            ev.Graphics.DrawString(lblCharge.Text, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 10;

            // 감사 인사
            ev.Graphics.DrawString(lblGreeting.Text, normalFont, Brushes.Black, leftMargin, yPos);

            ev.HasMorePages = false;
        }
        private void ApplyModernDesign()
        {
            // 1. 전체 배경색 (깔끔한 영수증 흰색)
            this.BackColor = Color.White;

            Color darkText = Color.FromArgb(62, 39, 35); // 진갈색 텍스트

            // 2. 상단 타이틀 바
            tlpTitle.BackColor = Color.FromArgb(90, 61, 49);
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            lblTitle.Text = "영수증";

            btnFormClose.FlatStyle = FlatStyle.Flat;
            btnFormClose.FlatAppearance.BorderSize = 0;
            btnFormClose.BackColor = Color.FromArgb(90, 61, 49);
            btnFormClose.ForeColor = Color.White;
            btnFormClose.Cursor = Cursors.Hand;

            // 3. 타이틀
            lblOrderId.Font = new Font("맑은 고딕", 22F, FontStyle.Bold);
            lblOrderId.ForeColor = darkText;

            // 4. 날짜 및 시간
            lblDateTime.Font = new Font("맑은 고딕", 10F);
            lblDateTime.ForeColor = Color.Gray;

            // 5. 주문 내역 리스트박스
            lstOrderList.Font = new Font("맑은 고딕", 11F);
            lstOrderList.ForeColor = darkText;
            lstOrderList.BackColor = Color.White;
            lstOrderList.BorderStyle = BorderStyle.None;

            // 6. 결제 내역 패널 및 텍스트 (★ 잘림 현상 해결)
            pnPrice.BackColor = Color.White;
            pnPrice.BorderStyle = BorderStyle.None;

            // AutoSize를 끄고 폰트 크기에 맞춰 라벨 높이를 넉넉하게 키워줍니다 (윗부분 잘림 방지)
            lblTotal.AutoSize = false;
            lblTotal.Height = 35;
            lblTotal.Font = new Font("맑은 고딕", 16F, FontStyle.Bold);
            lblTotal.ForeColor = darkText;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;

            lblReceived.AutoSize = false;
            lblReceived.Height = 25;
            lblReceived.Font = new Font("맑은 고딕", 11F);
            lblReceived.ForeColor = Color.Gray;
            lblReceived.TextAlign = ContentAlignment.MiddleRight;

            lblCharge.AutoSize = false;
            lblCharge.Height = 30;
            lblCharge.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
            lblCharge.ForeColor = Color.FromArgb(216, 67, 21); // 주황색 포인트
            lblCharge.TextAlign = ContentAlignment.MiddleRight;

            // 7. 인사말
            lblGreeting.Font = new Font("맑은 고딕", 11F);
            lblGreeting.ForeColor = Color.Gray;

            // 8. 하단 버튼 배치 (★ 출력 버튼을 하단 닫기 버튼 옆으로 이동)
            // 두 개의 버튼이 하단에 나란히 배치되도록 크기와 위치를 강제 조정합니다.
            int btnWidth = (this.Width - 60) / 2;
            int btnY = this.Height - 75; // 폼 맨 아래에서 살짝 띄운 위치

            // 출력 버튼 디자인 (테두리만 있는 깔끔한 스타일)
            btnPrint.Size = new Size(btnWidth, 45);
            btnPrint.Location = new Point(20, btnY);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.FlatAppearance.BorderSize = 1;
            btnPrint.FlatAppearance.BorderColor = Color.FromArgb(90, 61, 49);
            btnPrint.BackColor = Color.White;
            btnPrint.ForeColor = darkText;
            btnPrint.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; // 폼 크기 변경 대비

            // 닫기 버튼 디자인 (기존의 갈색 꽉 찬 스타일)
            btnClose.Size = new Size(btnWidth, 45);
            btnClose.Location = new Point(40 + btnWidth, btnY);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.BackColor = Color.FromArgb(90, 61, 49);
            btnClose.ForeColor = Color.White;
            btnClose.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // 9. 영수증 폼 구분선(가로줄) 자동 그리기
            this.Paint += (s, e) =>
            {
                Pen pen = new Pen(Color.LightGray, 2);
                int margin = 30; // 선 양옆 여백

                // 날짜 위아래, 리스트박스 아래에 맞춰 선 긋기
                int line1Y = lblDateTime.Top - 5;
                int line2Y = lblDateTime.Bottom + 5;
                int line3Y = lstOrderList.Bottom + 10;

                e.Graphics.DrawLine(pen, margin, line1Y, this.Width - margin, line1Y);
                e.Graphics.DrawLine(pen, margin, line2Y, this.Width - margin, line2Y);
                e.Graphics.DrawLine(pen, margin, line3Y, this.Width - margin, line3Y);
            };
        }
    }

}
