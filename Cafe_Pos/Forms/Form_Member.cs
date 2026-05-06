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
            ApplyModernDesign();
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

        private void ApplyModernDesign()
        {
            // 1. 폼 전체 배경색 (연한 회색/베이지)
            this.BackColor = Color.FromArgb(248, 248, 248);

            // 2. 컨트롤 디자인 일괄 탐색 및 적용
            ApplyStyleToAllControls(this);
        }

        private void ApplyStyleToAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // 1. 버튼 디자인
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Cursor = Cursors.Hand;

                    if (btn.Text.ToUpper() == "X") 
                    {
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.FromArgb(90, 61, 49); 
                        btn.ForeColor = Color.White;
                    }
                    else if (btn.Text.Contains("회원가입")) 
                    {
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.FromArgb(216, 67, 21);
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                    }
                    else if (btn.Text.Contains("취소")) // 서브 액션 버튼
                    {
                        btn.FlatAppearance.BorderColor = Color.FromArgb(180, 170, 160);
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.FromArgb(62, 39, 35); 
                        btn.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                    }
                }
                // 2. Label 디자인
                else if (ctrl is Label lbl)
                {
                    if (lbl.Text == "회원가입" && lbl.Parent is Panel pnl)
                    {
                        pnl.BackColor = Color.FromArgb(90, 61, 49);
                        lbl.ForeColor = Color.White;
                        lbl.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
                    }
                    else if (lbl.Text.Contains("적립"))
                    {
                        lbl.ForeColor = Color.FromArgb(62, 39, 35);
                        lbl.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
                    }
                    else if (lbl.Text == "이름" || lbl.Text == "전화번호")
                    {
                        lbl.ForeColor = Color.FromArgb(62, 39, 35);
                        lbl.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
                    }
                }
                // 3. textbox 디자인
                else if (ctrl is TextBox txt)
                {
                    txt.Font = new Font("맑은 고딕", 14F);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }

                // 패널 안에 있는 컨트롤들도 놓치지 않고 탐색
                if (ctrl.HasChildren)
                {
                    ApplyStyleToAllControls(ctrl);
                }
            }
        }
    }
}
