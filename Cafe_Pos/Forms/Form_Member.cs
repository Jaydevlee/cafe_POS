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
    public partial class Form_Member : Form
    {
        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;

        Member member = new Member();
        private OrderRepostiory orderRepostiory = new OrderRepostiory();
        public Form_Member()
        {
            InitializeComponent();
            btnFormClose.Click += btnFormClose_Clilck;
            btnInsert.Click += btnInsertMem_Click;
        }

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

        private void btnInsertMem_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            member = new Member
            {
                name = name,
                phone = phone,
            };
            orderRepostiory.InsertMember(member);
            this.Close();
        }
    }
}
