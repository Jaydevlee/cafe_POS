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
        private List<Orders> orders { get; set; }
        public Form_Main()
        {
            InitializeComponent();
            OrderList = new Dictionary<string, OrderItems>();
            orders = new List<Orders>();
            btnCoffee.Click += btnCoffee_Click;
            btnNonCoffee.Click += btnNonCoffee_Click;
            btnTea.Click += btnTea_Click;
            btnDessert.Click += btnDessert_Click;
            lstOrder.DoubleClick += lstOrder_DoubleClick;
            btnPurchase.Click += btnPurchase_Click;
        }
        // ListBox에 주문 내역 표시를 위히 Dictionary 사용


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
                Button btn = new Button();
                btn.Text = item.Name + "\n" + item.Price + "원";
                btn.Width = 100;
                btn.Height = 80;
                btn.Tag = item;
                btn.Click += btn_Click;
                fplButtons.Controls.Add(btn);
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
                Button btn = new Button();
                btn.Text = item.Name + "\n" + item.Price + "원";
                btn.Width = 100;
                btn.Height = 80;
                btn.Tag = item;
                btn.Click += btn_Click;
                fplButtons.Controls.Add(btn);
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
                Button btn = new Button();
                btn.Text = item.Name + "\n" + item.Price + "원";
                btn.Width = 100;
                btn.Height = 80;
                btn.Tag = item;
                btn.Click += btn_Click;
                fplButtons.Controls.Add(btn);
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
                Button btn = new Button();
                btn.Text = item.Name + "\n" + item.Price + "원";
                btn.Width = 100;
                btn.Height = 80;
                btn.Tag = item;
                btn.Click += btn_Click;
                fplButtons.Controls.Add(btn);
            }
        }


        /////////////////////////////////////////////////////////////
        /// 버튼 클릭 시 주문 내역 추가 및 총합계 계산 /////////////
        ///////////////////////////////////////////////////////////
        private void btn_Click(object? sender, EventArgs e)
        {

            Button btn = (Button)sender;
            MenuItem item = (MenuItem)btn.Tag;
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
            Form_PurchaseDial form = new Form_PurchaseDial(OrderList, this);
            form.ShowDialog();
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
            lstOrder.Items.Clear ();
        }
    }
}
