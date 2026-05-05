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
                // [버튼 디자인] - 텍스트에 따라 디자인 분기
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Cursor = Cursors.Hand;

                    if (btn.Text.ToUpper() == "X") // 상단 닫기 버튼
                    {
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.FromArgb(90, 61, 49); // 타이틀바와 같은 갈색
                        btn.ForeColor = Color.White;
                    }
                    else if (btn.Text.Contains("회원가입")) // 메인 액션 버튼
                    {
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.FromArgb(216, 67, 21); // 메인 테마 주황/빨강
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                    }
                    else if (btn.Text.Contains("취소")) // 서브 액션 버튼
                    {
                        btn.FlatAppearance.BorderColor = Color.FromArgb(180, 170, 160); // 연한 테두리
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.FromArgb(62, 39, 35); // 진갈색 텍스트
                        btn.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                    }
                }
                // [라벨 디자인] - 역할에 맞게 폰트 크기 및 색상 조정
                else if (ctrl is Label lbl)
                {
                    // 상단 타이틀바 라벨 ("회원가입") 및 패널 색상 처리
                    if (lbl.Text == "회원가입" && lbl.Parent is Panel pnl)
                    {
                        pnl.BackColor = Color.FromArgb(90, 61, 49); // 타이틀바 갈색 배경
                        lbl.ForeColor = Color.White;
                        lbl.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
                    }
                    // 메인 안내 문구 ("회원이 되셔서...")
                    else if (lbl.Text.Contains("적립"))
                    {
                        lbl.ForeColor = Color.FromArgb(62, 39, 35);
                        lbl.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
                    }
                    // 입력칸 라벨 ("이름", "전화번호")
                    else if (lbl.Text == "이름" || lbl.Text == "전화번호")
                    {
                        lbl.ForeColor = Color.FromArgb(62, 39, 35);
                        lbl.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
                    }
                }
                // [텍스트박스 디자인] - 입력하기 편하도록 크기 확대
                else if (ctrl is TextBox txt)
                {
                    txt.Font = new Font("맑은 고딕", 14F);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    // 텍스트박스 테두리 색상은 WinForms 기본 속성상 직접 변경이 까다로우므로 FixedSingle로 깔끔하게 처리
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
