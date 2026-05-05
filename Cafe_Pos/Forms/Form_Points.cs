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
    public partial class Form_Points : Form
    {
        Member member = new Member();

        private OrderRepostiory orderRepository = new OrderRepostiory();
        // 창 이동 전역 변수
        bool mouseDown;
        Point lastLotion;
        public Form_Points()
        {
            InitializeComponent();
            btnFormClose.Click += btnFormClose_Clilck;
            btnInsertMem.Click += btnInsertMem_Click;
            btnAddPoints.Click += btnAddPoints_Click;
            btnSkip.Click += btnSkip_Click;
        }

        public delegate void PointHandler(bool addPoints, string phone);
        public event PointHandler OnComplete;

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

        private void btnInsertMem_Click(object? sender, EventArgs e)
        {
            Form_Member form = new Form_Member();
            form.ShowDialog();
        }


        private void btnAddPoints_Click(object? sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            Member? member = orderRepository.SelectMember(phone);

            if (member == null)
            {
                MessageBox.Show("회원정보가 존재하지 않습니다. 회원가입을 진행해주세요.");
                return;
            }

            OnComplete(true, phone);
            this.Close();
        }

        private void btnSkip_Click(object? sender, EventArgs e)
        {
            OnComplete(false, "");
            this.Close();
        }
    }
}
