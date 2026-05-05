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
        private MenuRepository menuRepository = new MenuRepository();

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
            btnEvent();
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
            if (listMenu.Columns[e.ColumnIndex].Name == "Is_active")
            {
                if (e.Value != null)
                {
                    Console.WriteLine(e.Value.GetType());
                    {
                        int stringValue = (int)e.Value;
                        if (stringValue == 1)
                        {
                            e.Value = "판매중";
                        }
                        else if (stringValue == 0)
                        {
                            e.Value = "품절";
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
            foreach(MenuItem menuItem in list) 
            { 
                if(menuItem.Name == txtMenuName.Text)
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
                } else
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
            } else
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
    }
}
