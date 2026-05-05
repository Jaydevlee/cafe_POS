namespace Cafe_Pos.Forms
{
    partial class Form_Admin
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
            components = new System.ComponentModel.Container();
            dsMenu = new BindingSource(components);
            dsCategory = new BindingSource(components);
            dsStatus = new BindingSource(components);
            tlpMainTitle = new TableLayoutPanel();
            btnMin = new Button();
            btnMax = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            tabAdmin = new TabControl();
            tabMenuPage = new TabPage();
            pnMenu = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbStatus = new ComboBox();
            cmbCategory = new ComboBox();
            txtPrice = new TextBox();
            lblStatus = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            txtMenuName = new TextBox();
            lblMenuName = new Label();
            listMenu = new DataGridView();
            lblEditMenu = new Label();
            lblListMenu = new Label();
            tabMember = new TabPage();
            pnMember = new Panel();
            lblPoints = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtName = new TextBox();
            lblName = new Label();
            dgvMember = new DataGridView();
            dsMembers = new BindingSource(components);
            displayPoints = new Label();
            ((System.ComponentModel.ISupportInitialize)dsMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsStatus).BeginInit();
            tlpMainTitle.SuspendLayout();
            tabAdmin.SuspendLayout();
            tabMenuPage.SuspendLayout();
            pnMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listMenu).BeginInit();
            tabMember.SuspendLayout();
            pnMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsMembers).BeginInit();
            SuspendLayout();
            // 
            // tlpMainTitle
            // 
            tlpMainTitle.BackColor = Color.FromArgb(93, 55, 55);
            tlpMainTitle.ColumnCount = 4;
            tlpMainTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpMainTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpMainTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpMainTitle.Controls.Add(btnMin, 1, 0);
            tlpMainTitle.Controls.Add(btnMax, 2, 0);
            tlpMainTitle.Controls.Add(btnClose, 3, 0);
            tlpMainTitle.Controls.Add(lblTitle, 0, 0);
            tlpMainTitle.Dock = DockStyle.Top;
            tlpMainTitle.Location = new Point(0, 0);
            tlpMainTitle.Name = "tlpMainTitle";
            tlpMainTitle.RowCount = 1;
            tlpMainTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainTitle.Size = new Size(948, 37);
            tlpMainTitle.TabIndex = 10;
            tlpMainTitle.MouseDown += lblTitle_MouseDown;
            tlpMainTitle.MouseMove += lblTitle_MouseMove;
            tlpMainTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(846, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(29, 31);
            btnMin.TabIndex = 1;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Font = new Font("맑은 고딕", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnMax.Location = new Point(881, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 31);
            btnMax.TabIndex = 2;
            btnMax.Text = "□";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Button;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(916, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(314, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "☕커피한잔 POS - 괸라자 메뉴(메뉴관리)";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabMenuPage);
            tabAdmin.Controls.Add(tabMember);
            tabAdmin.Location = new Point(3, 43);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(933, 591);
            tabAdmin.TabIndex = 11;
            // 
            // tabMenuPage
            // 
            tabMenuPage.Controls.Add(pnMenu);
            tabMenuPage.Controls.Add(listMenu);
            tabMenuPage.Controls.Add(lblEditMenu);
            tabMenuPage.Controls.Add(lblListMenu);
            tabMenuPage.Location = new Point(4, 29);
            tabMenuPage.Name = "tabMenuPage";
            tabMenuPage.Padding = new Padding(3);
            tabMenuPage.Size = new Size(925, 558);
            tabMenuPage.TabIndex = 0;
            tabMenuPage.Text = "메뉴관리";
            tabMenuPage.UseVisualStyleBackColor = true;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.WhiteSmoke;
            pnMenu.BorderStyle = BorderStyle.FixedSingle;
            pnMenu.Controls.Add(tableLayoutPanel1);
            pnMenu.Controls.Add(cmbStatus);
            pnMenu.Controls.Add(cmbCategory);
            pnMenu.Controls.Add(txtPrice);
            pnMenu.Controls.Add(lblStatus);
            pnMenu.Controls.Add(lblPrice);
            pnMenu.Controls.Add(lblCategory);
            pnMenu.Controls.Add(txtMenuName);
            pnMenu.Controls.Add(lblMenuName);
            pnMenu.Location = new Point(568, 27);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(340, 520);
            pnMenu.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnUpdate, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel1.Location = new Point(14, 445);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(314, 60);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 54);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(107, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 54);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(216, 67, 21);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(211, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 54);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("맑은 고딕", 18F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(14, 372);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(311, 49);
            cmbStatus.TabIndex = 9;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("맑은 고딕", 18F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(14, 154);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(311, 49);
            cmbCategory.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPrice.Location = new Point(14, 260);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(311, 47);
            txtPrice.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(14, 334);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "상태";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(14, 225);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "가격";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(14, 121);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "카테고리";
            // 
            // txtMenuName
            // 
            txtMenuName.BorderStyle = BorderStyle.FixedSingle;
            txtMenuName.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtMenuName.Location = new Point(14, 47);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.Size = new Size(311, 47);
            txtMenuName.TabIndex = 3;
            // 
            // lblMenuName
            // 
            lblMenuName.AutoSize = true;
            lblMenuName.Location = new Point(14, 12);
            lblMenuName.Name = "lblMenuName";
            lblMenuName.Size = new Size(74, 20);
            lblMenuName.TabIndex = 2;
            lblMenuName.Text = "메뉴 이름";
            // 
            // listMenu
            // 
            listMenu.AllowUserToAddRows = false;
            listMenu.BackgroundColor = Color.WhiteSmoke;
            listMenu.ColumnHeadersHeight = 50;
            listMenu.GridColor = Color.White;
            listMenu.Location = new Point(6, 26);
            listMenu.Name = "listMenu";
            listMenu.RowHeadersVisible = false;
            listMenu.RowHeadersWidth = 20;
            listMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listMenu.Size = new Size(531, 521);
            listMenu.TabIndex = 6;
            // 
            // lblEditMenu
            // 
            lblEditMenu.AutoSize = true;
            lblEditMenu.Location = new Point(568, 3);
            lblEditMenu.Name = "lblEditMenu";
            lblEditMenu.Size = new Size(74, 20);
            lblEditMenu.TabIndex = 5;
            lblEditMenu.Text = "메뉴 편집";
            // 
            // lblListMenu
            // 
            lblListMenu.AutoSize = true;
            lblListMenu.Location = new Point(6, 3);
            lblListMenu.Name = "lblListMenu";
            lblListMenu.Size = new Size(74, 20);
            lblListMenu.TabIndex = 4;
            lblListMenu.Text = "메뉴 목록";
            // 
            // tabMember
            // 
            tabMember.Controls.Add(pnMember);
            tabMember.Controls.Add(dgvMember);
            tabMember.Location = new Point(4, 29);
            tabMember.Name = "tabMember";
            tabMember.Padding = new Padding(3);
            tabMember.Size = new Size(925, 558);
            tabMember.TabIndex = 1;
            tabMember.Text = "회원조회";
            tabMember.UseVisualStyleBackColor = true;
            // 
            // pnMember
            // 
            pnMember.Controls.Add(displayPoints);
            pnMember.Controls.Add(lblPoints);
            pnMember.Controls.Add(txtPhone);
            pnMember.Controls.Add(lblPhone);
            pnMember.Controls.Add(txtName);
            pnMember.Controls.Add(lblName);
            pnMember.Location = new Point(658, 35);
            pnMember.Name = "pnMember";
            pnMember.Size = new Size(245, 517);
            pnMember.TabIndex = 1;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("맑은 고딕", 15F);
            lblPoints.Location = new Point(13, 247);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(90, 35);
            lblPoints.TabIndex = 11;
            lblPoints.Text = "포인트";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("맑은 고딕", 15F);
            txtPhone.Location = new Point(13, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(208, 41);
            txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("맑은 고딕", 15F);
            lblPhone.Location = new Point(13, 129);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(115, 35);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "전화번호";
            // 
            // txtName
            // 
            txtName.Font = new Font("맑은 고딕", 15F);
            txtName.Location = new Point(13, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 41);
            txtName.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("맑은 고딕", 15F);
            lblName.Location = new Point(13, 16);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 35);
            lblName.TabIndex = 7;
            lblName.Text = "이름";
            // 
            // dgvMember
            // 
            dgvMember.AllowUserToAddRows = false;
            dgvMember.BackgroundColor = Color.WhiteSmoke;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(6, 35);
            dgvMember.Name = "dgvMember";
            dgvMember.ReadOnly = true;
            dgvMember.RowHeadersVisible = false;
            dgvMember.RowHeadersWidth = 51;
            dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMember.Size = new Size(623, 520);
            dgvMember.TabIndex = 0;
            // 
            // displayPoints
            // 
            displayPoints.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            displayPoints.ForeColor = Color.FromArgb(216, 67, 21);
            displayPoints.Location = new Point(41, 308);
            displayPoints.Name = "displayPoints";
            displayPoints.Size = new Size(172, 47);
            displayPoints.TabIndex = 12;
            displayPoints.Text = "0";
            displayPoints.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form_Admin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 642);
            Controls.Add(tabAdmin);
            Controls.Add(tlpMainTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Admin";
            Text = "커피한잔POS - 관리자(메뉴 관리)";
            ((System.ComponentModel.ISupportInitialize)dsMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsStatus).EndInit();
            tlpMainTitle.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tabMenuPage.ResumeLayout(false);
            tabMenuPage.PerformLayout();
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listMenu).EndInit();
            tabMember.ResumeLayout(false);
            pnMember.ResumeLayout(false);
            pnMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource dsMenu;
        private BindingSource dsCategory;
        private BindingSource dsStatus;
        private TableLayoutPanel tlpMainTitle;
        private Button btnMin;
        private Button btnMax;
        private Button btnClose;
        private Label lblTitle;
        private TabControl tabAdmin;
        private TabPage tabMenuPage;
        private TabPage tabMember;
        private Panel pnMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cmbStatus;
        private ComboBox cmbCategory;
        private TextBox txtPrice;
        private Label lblStatus;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox txtMenuName;
        private Label lblMenuName;
        private DataGridView listMenu;
        private Label lblEditMenu;
        private Label lblListMenu;
        private DataGridView dgvMember;
        private BindingSource dsMembers;
        private Panel pnMember;
        private Label lblPoints;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtName;
        private Label lblName;
        private Label displayPoints;
    }
}