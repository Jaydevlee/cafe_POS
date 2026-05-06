using Cafe_Pos.Data;
using Cafe_Pos.Forms;
using Cafe_Pos.Models;
using MySqlConnector;
using MenuItem = Cafe_Pos.Models.MenuItem;
using System.ComponentModel;

namespace Cafe_Pos
{
    public partial class Form_Main : Form
    {
        private Dictionary<string, OrderItems> OrderList { get; set; }

        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;


        public Form_Main()
        {
            InitializeComponent();
            ApplyModernDesign();
            OrderList = new Dictionary<string, OrderItems>();
            btnCoffee.Click += btnCoffee_Click;
            btnNonCoffee.Click += btnNonCoffee_Click;
            btnTea.Click += btnTea_Click;
            btnDessert.Click += btnDessert_Click;
            lstOrder.DoubleClick += lstOrder_DoubleClick;
            btnPurchase.Click += btnPurchase_Click;
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


        private void Form_Main_Load(object? sender, EventArgs e)
        {
            Coffee_Init();
        }

        // object 뒤의 ?는 null이 들어올 수 있다는 의미 C#6부터 nullable 엄격하게 따짐
        private void btnCoffee_Click(object? sender, EventArgs e)
        {
            Coffee_Init();
        }

        private void btnNonCoffee_Click(object? sender, EventArgs e)
        {
            NonCoffee_Init();
        }

        private void btnTea_Click(object? sender, EventArgs e)
        {
            Tea_Init();
        }


        private void btnDessert_Click(object? sender, EventArgs e)
        {
            Dessert_Init();
        }


        /////////////////////////////////////////////////////////////
        /// 카테고리 버튼 클릭했을 때 해당 카테고리의 메뉴버튼 /////
        ///////////////////////////////////////////////////////////
        private void Coffee_Init()
        {
            string category = btnCoffee.Text;
            MenuRepository menuRepository = new();
            List<MenuItem> list = menuRepository.SelectMenu(category);

            fplButtons.Controls.Clear();

            foreach (MenuItem item in list)
            {
                // 1. 패널 기본 설정
                Panel pn = new Panel();
                pn.Width = 230;
                pn.Height = 100;
                pn.BackColor = Color.White;
                pn.BorderStyle = BorderStyle.FixedSingle; // 사진처럼 외곽선 추가
                pn.Cursor = Cursors.Hand; // 마우스 오버 시 클릭 가능한 손가락 모양
                pn.Tag = item;      // 데이터 바인딩 유지

                // 2. 메뉴명 라벨 설정
                Label lblMenu = new Label();
                lblMenu.Text = item.Name;
                lblMenu.ForeColor = Color.FromArgb(62, 39, 35); 
                lblMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
                lblMenu.Dock = DockStyle.Top; // Location 대신 Dock을 사용하여 자동 중앙 정렬 유도
                lblMenu.Height = 50;
                lblMenu.TextAlign = ContentAlignment.BottomCenter; // 가격과 가깝게 배치

                // 3. 가격 라벨 설정
                Label lblPrice = new Label();
                lblPrice.Text = item.Price + "원";
                lblPrice.ForeColor = Color.FromArgb(216, 67, 21);
                lblPrice.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                lblPrice.Dock = DockStyle.Bottom; // 하단 영역에 자동 정렬
                lblPrice.Height = 50;
                lblPrice.TextAlign = ContentAlignment.TopCenter; // 메뉴명과 가깝게 배치

                // 4. 클릭 이벤트 통합
                // Label클릭시 패널 클릭이벤트 발생하도록
                // label의 sender를 panel타입으로 강제 전환
                pn.Click += pn_Click;
                lblMenu.Click += (s, e) => pn_Click(pn, e);
                lblPrice.Click += (s, e) => pn_Click(pn, e);

                // 5. 컨트롤 조립
                pn.Controls.Add(lblMenu);
                pn.Controls.Add(lblPrice);

                fplButtons.Controls.Add(pn);
            }
        }

        private void NonCoffee_Init()
        {
            string category = btnNonCoffee.Text;
            MenuRepository menuRepository = new();
            List<MenuItem> list = menuRepository.SelectMenu(category);
            fplButtons.Controls.Clear();

            foreach (MenuItem item in list)
            {
                // 1. 패널 기본 설정
                Panel pn = new Panel();
                pn.Width = 230;    
                pn.Height = 100;
                pn.BackColor = Color.White;
                pn.BorderStyle = BorderStyle.FixedSingle; // 사진처럼 외곽선 추가
                pn.Cursor = Cursors.Hand; // 마우스 오버 시 클릭 가능한 손가락 모양
                pn.Tag = item;      // 데이터 바인딩 유지

                // 2. 메뉴명 라벨 설정
                Label lblMenu = new Label();
                lblMenu.Text = item.Name;
                lblMenu.ForeColor = Color.FromArgb(62, 39, 35); 
                lblMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
                lblMenu.Dock = DockStyle.Top; // Location 대신 Dock을 사용하여 자동 중앙 정렬 유도
                lblMenu.Height = 50;
                lblMenu.TextAlign = ContentAlignment.BottomCenter; // 가격과 가깝게 배치

                // 3. 가격 라벨 설정
                Label lblPrice = new Label();
                lblPrice.Text = item.Price + "원";
                lblPrice.ForeColor = Color.FromArgb(216, 67, 21);
                lblPrice.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                lblPrice.Dock = DockStyle.Bottom; // 하단 영역에 자동 정렬
                lblPrice.Height = 50;
                lblPrice.TextAlign = ContentAlignment.TopCenter; // 메뉴명과 가깝게 배치

                // 4. 클릭 이벤트 통합 
                pn.Click += pn_Click;
                lblMenu.Click += (s, e) => pn_Click(pn, e);
                lblPrice.Click += (s, e) => pn_Click(pn, e);

                // 5. 컨트롤 조립
                pn.Controls.Add(lblMenu);
                pn.Controls.Add(lblPrice);

                fplButtons.Controls.Add(pn);
            }
        }

        private void Tea_Init()
        {
            string category = btnTea.Text;
            MenuRepository menuRepository = new();
            List<MenuItem> list = menuRepository.SelectMenu(category);
            fplButtons.Controls.Clear();
            foreach (MenuItem item in list)
            {
                // 1. 패널 기본 설정
                Panel pn = new Panel();
                pn.Width = 230;    
                pn.Height = 100;
                pn.BackColor = Color.White;
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Cursor = Cursors.Hand; // 마우스 오버 시 클릭 가능한 손가락 모양
                pn.Tag = item;      // 데이터 바인딩 유지

                // 2. 메뉴명 라벨 설정
                Label lblMenu = new Label();
                lblMenu.Text = item.Name;
                lblMenu.ForeColor = Color.FromArgb(62, 39, 35); 
                lblMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
                lblMenu.Dock = DockStyle.Top; // Location 대신 Dock을 사용하여 자동 중앙 정렬 유도
                lblMenu.Height = 50;
                lblMenu.TextAlign = ContentAlignment.BottomCenter; // 가격과 가깝게 배치

                // 3. 가격 라벨 설정
                Label lblPrice = new Label();
                lblPrice.Text = item.Price + "원";
                lblPrice.ForeColor = Color.FromArgb(216, 67, 21); // 작성하신 색상 유지
                lblPrice.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                lblPrice.Dock = DockStyle.Bottom; // 하단 영역에 자동 정렬
                lblPrice.Height = 50;
                lblPrice.TextAlign = ContentAlignment.TopCenter; // 메뉴명과 가깝게 배치

                // 4. 클릭 이벤트 통합
                // 라벨(글씨)을 클릭해도 pn_Click에서 (Panel)sender 처리를 
                // 오류 없이 할 수 있도록 sender를 pn으로 강제 지정하여 전달합
                pn.Click += pn_Click;
                lblMenu.Click += (s, e) => pn_Click(pn, e);
                lblPrice.Click += (s, e) => pn_Click(pn, e);

                // 5. 컨트롤 조립
                pn.Controls.Add(lblMenu);
                pn.Controls.Add(lblPrice);

                fplButtons.Controls.Add(pn);
            }
        }

        private void Dessert_Init()
        {
            string category = btnDessert.Text;
            MenuRepository menuRepository = new();
            List<MenuItem> list = menuRepository.SelectMenu(category);
            fplButtons.Controls.Clear();
            foreach (MenuItem item in list)
            {
                // 1. 패널 기본 설정
                Panel pn = new Panel();
                pn.Width = 230;  
                pn.Height = 100;
                pn.BackColor = Color.White;
                pn.BorderStyle = BorderStyle.FixedSingle; // 사진처럼 외곽선 추가
                pn.Cursor = Cursors.Hand; // 마우스 오버 시 클릭 가능한 손가락 모양
                pn.Tag = item;      // 데이터 바인딩 유지

                // 2. 메뉴명 라벨 설정
                Label lblMenu = new Label();
                lblMenu.Text = item.Name;
                lblMenu.ForeColor = Color.FromArgb(62, 39, 35); // 작성하신 색상 유지
                lblMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
                lblMenu.Dock = DockStyle.Top; // Location 대신 Dock을 사용하여 자동 중앙 정렬 유도
                lblMenu.Height = 50;
                lblMenu.TextAlign = ContentAlignment.BottomCenter; // 가격과 가깝게 배치

                // 3. 가격 라벨 설정
                Label lblPrice = new Label();
                lblPrice.Text = item.Price + "원";
                lblPrice.ForeColor = Color.FromArgb(216, 67, 21); // 작성하신 색상 유지
                lblPrice.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                lblPrice.Dock = DockStyle.Bottom; // 하단 영역에 자동 정렬
                lblPrice.Height = 50;
                lblPrice.TextAlign = ContentAlignment.TopCenter; // 메뉴명과 가깝게 배치

                // 4. 클릭 이벤트 통합
                pn.Click += pn_Click;
                lblMenu.Click += (s, e) => pn_Click(pn, e);
                lblPrice.Click += (s, e) => pn_Click(pn, e);

                // 5. 컨트롤 조립
                pn.Controls.Add(lblMenu);
                pn.Controls.Add(lblPrice);

                fplButtons.Controls.Add(pn);
            }
        }


        /////////////////////////////////////////////////////////////
        /// 버튼 클릭 시 주문 내역 추가 및 총합계 계산 /////////////
        ///////////////////////////////////////////////////////////
        // ListBox에 주문 내역 표시를 위히 Dictionary 사용
        private void pn_Click(object? sender, EventArgs e)
        {
            Label lbl = null;
            Panel pn = null;
            if (sender is Label)
            {
                lbl = (Label)sender;
                pn = (Panel)lbl.Parent;
            }
            else if (sender is Panel)
            {
                pn = (Panel)sender;
            }

            MenuItem item = (MenuItem)pn.Tag;
            //Dictionary 객체로 주문 내역을 넣어서 listbox로 전달
            if (OrderList.ContainsKey(item.Name))
            {
                OrderList[item.Name].Quantity++;
                OrderList[item.Name].Subtotal = OrderList[item.Name].Quantity * OrderList[item.Name].Price;
            }
            else
            {
                OrderList[item.Name] = new OrderItems
                {
                    Menu_id = item.Id,
                    Menu_name = item.Name,
                    Quantity = 1,
                    Price = item.Price,
                    Subtotal = item.Price
                };
            }

            lstOrder.Items.Clear();
            foreach (OrderItems order in OrderList.Values)
            {
                lstOrder.Items.Add(order.Menu_name + " " + order.Quantity + " " + order.Subtotal);
            }
            Calc_total();
        }

        // 더블클릭 이벤트
        private void lstOrder_DoubleClick(object? sender, EventArgs e)
        {
            int selectIndex = lstOrder.SelectedIndex;
            string menu = "";
            string quantity = "";
            if (selectIndex != -1)
            {
                menu = OrderList.Keys.ElementAt(selectIndex);
                quantity = OrderList.Keys.ElementAt(selectIndex);
                string menuName = OrderList[menu].Menu_name;
                string quantities = OrderList[menu].Quantity.ToString();

                Form_AmountDial form = new Form_AmountDial(menuName, quantities, OrderList);
                form.ShowDialog();

                //새로고침
                lstOrder.Items.Clear();
                foreach (OrderItems order in OrderList.Values)
                {
                    lstOrder.Items.Add(order.Menu_name + " " + order.Quantity + " " + order.Subtotal);
                }
                Calc_total();
            }
        }

        public void btnPurchase_Click(object? sender, EventArgs e)
        {
            if(OrderList == null || OrderList.Count == 0)
            {
                MessageBox.Show("메뉴를 선택해주세요");
                return;
            }
            using (Form_PurchaseDial form = new Form_PurchaseDial(OrderList))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Form_Main_Clear();
                }
            }   
        }
        private void Calc_total()
        {
            int sum = 0;
            foreach (OrderItems order in OrderList.Values)
            {
                sum += order.Subtotal;
            }
            displayTotal.Text = sum.ToString();
        }

        private void menuTool_Click(object sender, EventArgs e)
        {
            Form_Admin form = new();
            form.Show();
        }

        // 영수증 닫기 후 기존 내역 초기화
        public void Form_Main_Clear()
        {
            OrderList.Clear();
            lstOrder.Items.Clear();
        }

        private void toolSales_Click(object sender, EventArgs e)
        {
            Form_Sales form = new Form_Sales();
            form.Show();
        }

        private void toolOrder_Click(object sender, EventArgs e)
        {
            Form_Order form = new Form_Order();
            form.Show();
        }

        private void ApplyModernDesign()
        {
            // 1. 폼 전체 배경색 (연한 회색/베이지 톤)
            this.BackColor = Color.FromArgb(248, 248, 248);

            // 2. 상단 타이틀바 패널
            btnMin.BackColor = Color.FromArgb(93, 55, 55);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Cursor = Cursors.Hand;
            btnMax.BackColor = Color.FromArgb(93, 55, 55);
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.Cursor = Cursors.Hand;
            btnClose.BackColor = Color.FromArgb(93, 55, 55);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;                     
            btnClose.Cursor = Cursors.Hand;

            // 3. 카테고리 버튼 스타일 일괄 적용
            // btnCoffee, btnNonCoffee 등 버튼들을 묶어서 처리
            Button[] categoryButtons = { btnCoffee, btnNonCoffee, btnTea, btnDessert };
            foreach (Button btn in categoryButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.FromArgb(200, 190, 180);
                btn.BackColor = Color.FromArgb(220, 210, 205); // 기본 비활성 색상 (연한 베이지)
                btn.ForeColor = Color.Black;
                btn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
            }

            // 현재 선택된 '커피' 버튼 포인트 컬러 적용
            btnCoffee.BackColor = Color.FromArgb(90, 61, 49);
            btnCoffee.ForeColor = Color.White;

            // 4. 결제 및 취소 버튼 스타일
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.BackColor = Color.FromArgb(215, 65, 25); // 진한 주황/빨강
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);

            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatAppearance.BorderColor = Color.Gray;
            btnCancel.BackColor = Color.FromArgb(215, 205, 195);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);

            // 5. 합계 금액 라벨 포인트
            displayTotal.ForeColor = Color.FromArgb(215, 65, 25); // 결제 버튼과 동일한 주황/빨강
            displayTotal.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
        }
    }
}
