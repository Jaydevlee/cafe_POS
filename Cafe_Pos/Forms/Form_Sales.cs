using Cafe_Pos.Data;
using Cafe_Pos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cafe_Pos.Forms
{
    public partial class Form_Sales : Form
    {
        private OrderRepostiory orderRepository = new();

        private List<OrderTop5> list = new List<OrderTop5>();

        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;

        public Form_Sales()
        {
            InitializeComponent();
            PageInit();
            DrawChart();
            ApplyModernDesign();
        }

        //private void btnSelect_Click(object? sender, EventArgs e)
        //{
        //    ShowDateTimePick();
        //}

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
            LoadTop5(dateTime1, dateTime2);
            SelectGrowth();
            SelectAvg();
        }



        private void btnSelect_Click(object? sender, EventArgs e)
        {
            LoadSales();
        }

        private void btnToday_Click(object? sender, EventArgs e)
        {
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtpEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void btnSetMonth_Click(object? sender, EventArgs e)
        {
            int lastDay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, lastDay);
            string dateTime1 = dtpStart.Value.ToString("yyyy-MM-dd");
            string dateTime2 = dtpEnd.Value.ToString("yyyy-MM-dd");
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

            dgvTop5.Columns["name"].HeaderText = "메뉴";
            dgvTop5.Columns["quantity"].HeaderText = "수량";
            dgvTop5.Columns["subTotal"].HeaderText = "매출";
            dgvTop5.Columns["ratio"].HeaderText = "비중";

            dgvTop5.Columns["name"].Width = 300;
            dgvTop5.Columns["quantity"].Width = 150;
            dgvTop5.Columns["subTotal"].Width = 200;
            dgvTop5.Columns["ratio"].Width = 200;
        }

        // 전월 대비 매출 증가
        private void SelectGrowth()
        {
            double growth = 0;
            growth = orderRepository.SelectGrowthRatio();
            string displayGrowth = (Math.Round(growth, 2) * 100).ToString();
            lblGrowth.Text = $"전월 대비 {displayGrowth}%";
        }

        // 일 평균 주문 건수
        private void SelectAvg()
        {
            double avg = 0;
            avg = orderRepository.SelectAvgOrder();
            string displayAvg = Math.Round(avg, 1).ToString();
            lblAvgOrders.Text = $"일 평균 {displayAvg}건";

        }

        private void DrawChart()
        {
            List<OrderChart> list = orderRepository.SelectOrderByDate();

            chartOrder.Series.Clear();
            chartOrder.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartOrder.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series["PointWidth"] = "0.5";

            int i = 0;
            foreach (OrderChart item in list)
            {
                series.Points.AddXY(i, item.daily_total);
                series.Points[i].AxisLabel = item.order_date.ToString("MM-dd");
                i++;
            }

            chartOrder.Series.Add(series);
        }

        private void ApplyModernDesign()
        {
            // 1. 전체 배경색
            this.BackColor = Color.FromArgb(248, 248, 248);

            // 2. 폼 내의 모든 컨트롤 순회하며 스타일 적용
            ApplyStyleToAllControls(this);

            // 3. 포인트 라벨 색상 
            displayTotal.ForeColor = Color.FromArgb(216, 67, 21);
            displayOrders.ForeColor = Color.FromArgb(25, 118, 210);
            displayAvg.ForeColor = Color.FromArgb(56, 142, 60); 

        }

        private void ApplyStyleToAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // 1.dgv디자인
                if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.FixedSingle;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(90, 61, 49);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
                    dgv.ColumnHeadersHeight = 40;

                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = Color.Black;
                    dgv.DefaultCellStyle.Font = new Font("맑은 고딕", 10F);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 224, 180);
                    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dgv.RowTemplate.Height = 35;

                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.AllowUserToAddRows = false;
                    dgv.RowHeadersVisible = false;

                    // 순위(1~5) 컬럼 글씨색 주황색으로 변경하는 이벤트 연결
                    dgv.CellFormatting -= DgvTop5_CellFormatting;
                    dgv.CellFormatting += DgvTop5_CellFormatting;
                }
                // 2. 버튼 디자인
                else if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(90, 61, 49); // 조회 버튼 (갈색)
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }
                // 3. 차트디자인
                else if (ctrl is System.Windows.Forms.DataVisualization.Charting.Chart chart)
                {
                    ApplyChartDesign(chart);
                }

                if (ctrl.HasChildren)
                {
                    ApplyStyleToAllControls(ctrl);
                }
            }
        }

        private void ApplyChartDesign(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.BackColor = Color.White;
            // 테두리를 패널들과 동일한 연한 갈색으로 설정
            chart.BorderlineColor = Color.FromArgb(180, 170, 160);
            chart.BorderlineWidth = 1;
            chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;

            foreach (var chartArea in chart.ChartAreas)
            {
                chartArea.BackColor = Color.White;
                chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
                chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
                chartArea.AxisX.LineColor = Color.LightGray;
                chartArea.AxisY.LineColor = Color.LightGray;

                chartArea.AxisX.LabelStyle.Font = new Font("맑은 고딕", 9F);
                chartArea.AxisY.LabelStyle.Font = new Font("맑은 고딕", 9F);
            }

            // 색상 팔레트 
            Color[] customPalette = {
                Color.FromArgb(216, 67, 21),   // 메인 주황 (총 매출 색상과 통일)
                Color.FromArgb(90, 61, 49),    // 진갈색
                Color.FromArgb(205, 161, 114), // 라떼 베이지
                Color.FromArgb(56, 142, 60)    // 포인트 초록
                };

            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart.PaletteCustomColors = customPalette;

            // 범례(Legend) 폰트 설정
            if (chart.Legends.Count > 0)
            {
                chart.Legends[0].Font = new Font("맑은 고딕", 9F);
                chart.Legends[0].BackColor = Color.White;
            }
        }

        // DataGridView의 "순위" 컬럼 숫자를 사진처럼 주황색 굵은 글씨로 만드는 이벤트
        private void DgvTop5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            // 첫 번째 컬럼(인덱스 0)이 '순위'라고 가정. 
            // 만약 컬럼 이름이 "Rank" 등이라면 dgv.Columns[e.ColumnIndex].Name == "Rank" 로 변경하세요.
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.FromArgb(216, 67, 21); // 진한 주황
                e.CellStyle.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
            }
        }
    }
}
