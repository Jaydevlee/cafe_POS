namespace Cafe_Pos.Forms
{
    partial class Form_Member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpTitle = new TableLayoutPanel();
            btnFormClose = new Button();
            lblTitle = new Label();
            lblInsertMem = new Label();
            lblName = new Label();
            lblPhone = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnInsert = new Button();
            btnCancel = new Button();
            tlpTitle.SuspendLayout();
            SuspendLayout();
            // 
            // tlpTitle
            // 
            tlpTitle.BackColor = Color.FromArgb(93, 55, 55);
            tlpTitle.ColumnCount = 4;
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpTitle.Controls.Add(btnFormClose, 3, 0);
            tlpTitle.Controls.Add(lblTitle, 0, 0);
            tlpTitle.Dock = DockStyle.Top;
            tlpTitle.Location = new Point(0, 0);
            tlpTitle.Name = "tlpTitle";
            tlpTitle.RowCount = 1;
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitle.Size = new Size(800, 37);
            tlpTitle.TabIndex = 14;
            // 
            // btnFormClose
            // 
            btnFormClose.Location = new Point(768, 3);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(29, 31);
            btnFormClose.TabIndex = 3;
            btnFormClose.Text = "X";
            btnFormClose.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "회원가입";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInsertMem
            // 
            lblInsertMem.AutoSize = true;
            lblInsertMem.Font = new Font("맑은 고딕", 18F);
            lblInsertMem.Location = new Point(142, 82);
            lblInsertMem.Name = "lblInsertMem";
            lblInsertMem.Size = new Size(540, 41);
            lblInsertMem.TabIndex = 15;
            lblInsertMem.Text = "회원이 되셔서 포인트를 적립해보세요!";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("맑은 고딕", 15F);
            lblName.Location = new Point(142, 177);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 35);
            lblName.TabIndex = 16;
            lblName.Text = "이름";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("맑은 고딕", 15F);
            lblPhone.Location = new Point(142, 259);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(115, 35);
            lblPhone.TabIndex = 17;
            lblPhone.Text = "전화번호";
            // 
            // txtName
            // 
            txtName.Font = new Font("맑은 고딕", 15F);
            txtName.Location = new Point(290, 174);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 41);
            txtName.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("맑은 고딕", 15F);
            txtPhone.Location = new Point(290, 259);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(333, 41);
            txtPhone.TabIndex = 19;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(216, 67, 21);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(191, 328);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(171, 53);
            btnInsert.TabIndex = 20;
            btnInsert.Text = "회원가입";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(418, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 53);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form_Member
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(lblInsertMem);
            Controls.Add(tlpTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Member";
            Text = "Form_Member";
            tlpTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpTitle;
        private Button btnFormClose;
        private Label lblTitle;
        private Label lblInsertMem;
        private Label lblName;
        private Label lblPhone;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnInsert;
        private Button btnCancel;
    }
}