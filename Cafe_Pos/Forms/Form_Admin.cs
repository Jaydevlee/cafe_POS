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
        public Form_Admin()
        {
            InitializeComponent();
            LoadMenu();
            LoadMenuGrid();
            LoadCmbCategory();
            LoadCmbStatus();
            listMenu.CellFormatting += ListMenu_CellFormatting;
            btnEvent();
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
            //foreach (DataGridViewRow row in listMenu.Rows)
            //{
            //    if ()
            //    {
            //        row.SetValues = "판매중";

            //    }
            //}
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

        private void btnEvent()
        {
            btnAdd.Click += btnAdd_Click;
        }

        public void btnAdd_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(cmbCategory.SelectedItem.ToString());
            MessageBox.Show(cmbStatus.SelectedValue.ToString());

            menuItem = new MenuItem
            {
                Name = txtMenuName.Text,
                Category = (string)cmbCategory.SelectedItem,
                Price = Convert.ToInt32(txtPrice.Text),
                Is_active = Convert.ToInt32(cmbStatus.SelectedValue)
            };

            menuRepository.InsertMenu(menuItem);
        }
    }
}
