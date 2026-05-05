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
            ApplyModernDesign();
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
        private void ApplyModernDesign()
        {
            // 1. 폼 전체 배경색 (공통 연한 회색/베이지)
            this.BackColor = Color.FromArgb(248, 248, 248);

            // 2. 컨트롤 디자인 일괄 탐색 및 적용
            ApplyStyleToAllControls(this);
        }

        private void ApplyStyleToAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // [1] 버튼 디자인 (텍스트에 맞춰 세련된 포인트 컬러 자동 배정)
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;

                    string btnText = btn.Text.Trim();

                    if (btnText.ToUpper() == "X") // 상단 닫기 버튼
                    {
                        btn.BackColor = Color.FromArgb(90, 61, 49); // 타이틀바와 같은 갈색
                        btn.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
                    }
                    else if (btnText.Contains("회원가입"))
                    {
                        btn.BackColor = Color.FromArgb(56, 142, 60); // 차분한 초록색 (긍정/생성)
                        btn.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                    }
                    else if (btnText.Contains("적립"))
                    {
                        btn.BackColor = Color.FromArgb(25, 118, 210); // 모던한 파란색 (메인 액션)
                        btn.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                    }
                    else if (btnText.Contains("건너뛰기"))
                    {
                        btn.BackColor = Color.FromArgb(211, 47, 47); // 플랫한 빨간색 (취소/스킵)
                        btn.Font = new Font("맑은 고딕", 13F, FontStyle.Bold);
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(90, 61, 49); // 기본 갈색
                    }
                }
                // [2] 라벨 디자인
                else if (ctrl is Label lbl)
                {
                    // 상단 타이틀바 ("포인트 적립")
                    if (lbl.Text == "포인트 적립")
                    {
                        lbl.ForeColor = Color.White;
                        lbl.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);

                        // 타이틀을 감싸는 패널 색상 변경
                        if (lbl.Parent is Panel pnl)
                            pnl.BackColor = Color.FromArgb(90, 61, 49);
                    }
                    // 메인 안내 문구 ("포인트를 적립하시겠습니까?")
                    else if (lbl.Text.Contains("적립하시겠습니까"))
                    {
                        lbl.ForeColor = Color.FromArgb(62, 39, 35); // 진갈색
                        lbl.Font = new Font("맑은 고딕", 22F, FontStyle.Bold); // 눈에 띄게 큰 폰트
                    }
                }
                // [3] 텍스트박스 (전화번호 입력칸)
                else if (ctrl is TextBox txt)
                {
                    txt.Font = new Font("맑은 고딕", 18F, FontStyle.Bold); // 터치/클릭하기 좋게 큼직하게
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center; // 번호가 가운데 정렬되도록
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
