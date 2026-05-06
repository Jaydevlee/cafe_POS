using Cafe_Pos.Data;
using Cafe_Pos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using MenuItem = Cafe_Pos.Models.MenuItem;

namespace Cafe_Pos.Forms
{
    public partial class Form_Admin : Form
    {
        private MenuItem menuItem = new MenuItem();
        private List<MenuItem> list = new List<MenuItem>();
        private List<Member> members = new List<Member>();
        private MenuRepository menuRepository = new MenuRepository();

        private OrderRepostiory orderRepostiory = new OrderRepostiory();

        private int id { get; set; }
        private string name { get; set; }

        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;

        public Form_Admin()
        {
            InitializeComponent();
            LoadMenu();
            LoadMenuGrid();
            LoadCmbCategory();
            LoadCmbStatus();
            listMenu.CellFormatting += ListMenu_CellFormatting;
            listMenu.SelectionChanged += listMenu_SelectionChanged;
            dgvMember.SelectionChanged += dgvMember_SelectionChanged;
            LoadMemebers();
            btnEvent();
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


        public void LoadMenu()
        {
            list = menuRepository.SelectAllMenu();
        }

        public void LoadMenuGrid()
        {
            // Data바인딩
            dsMenu.DataSource = list;
            listMenu.DataSource = dsMenu;
            listMenu.Columns["Id"].HeaderText = "ID";
            listMenu.Columns["Name"].HeaderText = "이름";
            listMenu.Columns["Category"].HeaderText = "카테고리";
            listMenu.Columns["Price"].HeaderText = "가격";
            listMenu.Columns["Is_active"].HeaderText = "상태";

            listMenu.Columns["Id"].Width = 80;
            listMenu.Columns["Name"].Width = 150;
            listMenu.Columns["Category"].Width = 100;
            listMenu.Columns["Price"].Width = 80;
            listMenu.Columns["Is_active"].Width = 80;

            listMenu.RowHeadersWidth = 4;
            listMenu.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            listMenu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        // 메뉴목록에서 판매중 열의 값 이벤트
        public void ListMenu_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            // 현재 처리 중인 컬럼이 "Is_active" (상태) 컬럼인지 확인
            if (sender is DataGridView dgv && dgv.Columns[e.ColumnIndex].Name == "Is_active")
            {
                if (e.Value != null)
                {
                    // DB에서 int 타입으로 넘어오므로 안전하게 변환
                    if (int.TryParse(e.Value.ToString(), out int statusValue))
                    {
                        if (statusValue == 1)
                        {
                            e.Value = "판매중"; // 텍스트 변환
                            e.CellStyle.ForeColor = Color.FromArgb(56, 142, 60); // 초록색
                            e.CellStyle.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
                            e.FormattingApplied = true; // 시스템에 "내가 변환을 완료했다"고 알림
                        }
                        else if (statusValue == 0)
                        {
                            e.Value = "품절"; // 텍스트 변환
                            e.CellStyle.ForeColor = Color.FromArgb(211, 47, 47); // 빨간색
                            e.CellStyle.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
        }

        //카테고리 콤보박스 binding
        private void LoadCmbCategory()
        {
            List<string> list = new List<string>();
            list = menuRepository.SelectCategory();
            dsCategory.DataSource = list;
            cmbCategory.DataSource = dsCategory;
        }

        // 상태 콤보박스 binding
        private void LoadCmbStatus()
        {
            var pair1 = new KeyValuePair<string, int>("판매중", 1);
            var pair2 = new KeyValuePair<string, int>("품절", 0);
            List<KeyValuePair<string, int>> statusList = new List<KeyValuePair<string, int>>();
            statusList.Add(pair1);
            statusList.Add(pair2);

            dsStatus.DataSource = statusList;
            cmbStatus.DataSource = dsStatus;
            cmbStatus.DisplayMember = "Key";
            cmbStatus.ValueMember = "Value";
        }

        //DataGridView row select 이벤트
        private void listMenu_SelectionChanged(object? sender, EventArgs e)
        {
            if (listMenu.SelectedRows.Count > 0) Change_pnMenu();
        }

        private void Change_pnMenu()
        {
            DataGridViewRow row = listMenu.SelectedRows[0];
            id = int.Parse(row.Cells["Id"].Value.ToString());
            txtMenuName.Text = row.Cells["Name"].Value.ToString();
            cmbCategory.SelectedItem = row.Cells["Category"].Value;
            txtPrice.Text = row.Cells["price"].Value.ToString();
            cmbStatus.SelectedValue = row.Cells["Is_active"].Value;
        }

        private void btnEvent()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        public void btnAdd_Click(object? sender, EventArgs e)
        {
            foreach (MenuItem menuItem in list)
            {
                if (menuItem.Name == txtMenuName.Text)
                {
                    MessageBox.Show("이미 존재하는 메뉴 입니다.");
                    return;
                }
            }

            menuItem = new MenuItem
            {
                Name = txtMenuName.Text,
                Category = Convert.ToString(cmbCategory.SelectedItem),
                Price = Convert.ToInt32(txtPrice.Text),
                Is_active = Convert.ToInt32(cmbStatus.SelectedValue)
            };

            menuRepository.InsertMenu(menuItem);
        }

        public void btnUpdate_Click(object? sender, EventArgs e)
        {
            int result = 0;
            bool exists = false;
            foreach (MenuItem menuItem in list)
            {
                if (menuItem.Name.Contains(txtMenuName.Text))
                {
                    exists = true;
                    break;
                }
                else
                {
                    exists = false;
                }
            }

            if (exists)
            {
                menuItem = new MenuItem
                {
                    Id = id,
                    Name = txtMenuName.Text,
                    Category = Convert.ToString(cmbCategory.SelectedItem),
                    Price = Convert.ToInt32(txtPrice.Text),
                    Is_active = Convert.ToInt32(cmbStatus.SelectedValue)
                };

                menuRepository.UpdateMenu(menuItem);
            }
            else
            {
                MessageBox.Show("존재하지 않는 메뉴입니다.");
                return;
            }
        }

        public void btnDelete_Click(object? sender, EventArgs e)
        {
            // 삭제 기능 구현(menuId)사용
            menuItem = new MenuItem
            {
                Id = id
            };

            menuRepository.DeleteMenu(menuItem);
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtMenuName.Text = "";
            cmbCategory.SelectedItem = "커피";
            txtPrice.Text = "";
            cmbStatus.SelectedValue = 1;
        }

        ////////////////////////////////
        /////////// 회원관리 ///////////
        ////////////////////////////////
        private void LoadMemebers()
        {
            members = orderRepostiory.SelectAllMember();
            dsMembers.DataSource = members;
            dgvMember.DataSource = dsMembers;

            dgvMember.Columns["id"].HeaderText = "회원번호";
            dgvMember.Columns["name"].HeaderText = "이름";
            dgvMember.Columns["phone"].HeaderText = "전화번호";
            dgvMember.Columns["points"].HeaderText = "포인트";
        }

        //DataGridView row select 이벤트
        private void dgvMember_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count > 0) Change_pnMember();
        }

        private void Change_pnMember()
        {
            DataGridViewRow row = dgvMember.SelectedRows[0];
            id = int.Parse(row.Cells["id"].Value.ToString());
            txtName.Text = row.Cells["name"].Value.ToString();
            txtPhone.Text = row.Cells["phone"].Value.ToString();
            displayPoints.Text = row.Cells["points"].Value.ToString();
        }

        private void ApplyModernDesign()
        {
            // 1. 폼 전체 배경색
            this.BackColor = Color.FromArgb(248, 248, 248);

            // 2. 폼 내의 모든 컨트롤(탭 페이지 포함)을 순회하며 스타일 적용
            ApplyStyleToAllControls(this);
        }

        private void ApplyStyleToAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // 1. DataGridView 디자인
                if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.FixedSingle;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                    // 헤더 스타일 (갈색 배경, 흰색 글씨)
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(90, 61, 49);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
                    dgv.ColumnHeadersHeight = 40;

                    // 행(Row) 스타일
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = Color.Black;
                    dgv.DefaultCellStyle.Font = new Font("맑은 고딕", 10F);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 224, 180); // 연한 주황/베이지색 하이라이트
                    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dgv.RowTemplate.Height = 35;

                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.AllowUserToAddRows = false; // 빈 하단 행 제거
                    dgv.RowHeadersVisible = false;  // 왼쪽 화살표 열 숨김

                    // 컬럼(판매중/품절) 글씨 색상 자동 변경 이벤트 연결
                    dgv.CellFormatting -= ListMenu_CellFormatting;// 중복 방지
                    dgv.CellFormatting += ListMenu_CellFormatting;
                }
                // 2. 탭 페이지 배경색 투명화
                else if (ctrl is TabPage tabPage)
                {
                    tabPage.BackColor = Color.FromArgb(248, 248, 248);
                }
                // 3. 버튼 디자인
                else if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;

                    if (btn.Text.Contains("추가"))
                        btn.BackColor = Color.FromArgb(56, 142, 60); // 초록색
                    else if (btn.Text.Contains("수정"))
                        btn.BackColor = Color.FromArgb(25, 118, 210); // 파란색
                    else if (btn.Text.Contains("삭제"))
                        btn.BackColor = Color.FromArgb(211, 47, 47); // 빨간색
                    else
                        btn.BackColor = Color.FromArgb(90, 61, 49); // 기본 갈색 (닫기 등)
                }
                // 4. TextBox, ComboBox 디자인
                else if (ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.Font = new Font("맑은 고딕", 11F);
                }

                // 컨테이너 컨트롤(Panel, TabControl 등) 안에 다른 컨트롤이 있다면 디자인 적용
                if (ctrl.HasChildren)
                {
                    ApplyStyleToAllControls(ctrl);
                }
            }
        }
    }
}
