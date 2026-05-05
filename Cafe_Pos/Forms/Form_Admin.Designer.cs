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
            lblListMenu = new Label();
            lblEditMenu = new Label();
            listMenu = new DataGridView();
            dsMenu = new BindingSource(components);
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
            dsCategory = new BindingSource(components);
            dsStatus = new BindingSource(components);
            tlpMainTitle = new TableLayoutPanel();
            btnMin = new Button();
            btnMax = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)listMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsMenu).BeginInit();
            pnMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsStatus).BeginInit();
            tlpMainTitle.SuspendLayout();
            SuspendLayout();
            // 
            // lblListMenu
            // 
            lblListMenu.AutoSize = true;
            lblListMenu.Location = new Point(12, 47);
            lblListMenu.Name = "lblListMenu";
            lblListMenu.Size = new Size(74, 20);
            lblListMenu.TabIndex = 0;
            lblListMenu.Text = "메뉴 목록";
            // 
            // lblEditMenu
            // 
            lblEditMenu.AutoSize = true;
            lblEditMenu.Location = new Point(581, 47);
            lblEditMenu.Name = "lblEditMenu";
            lblEditMenu.Size = new Size(74, 20);
            lblEditMenu.TabIndex = 1;
            lblEditMenu.Text = "메뉴 편집";
            // 
            // listMenu
            // 
            listMenu.AllowUserToAddRows = false;
            listMenu.BackgroundColor = Color.WhiteSmoke;
            listMenu.ColumnHeadersHeight = 50;
            listMenu.GridColor = Color.White;
            listMenu.Location = new Point(12, 89);
            listMenu.Name = "listMenu";
            listMenu.ReadOnly = true;
            listMenu.RowHeadersVisible = false;
            listMenu.RowHeadersWidth = 20;
            listMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listMenu.Size = new Size(531, 521);
            listMenu.TabIndex = 2;
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
            pnMenu.Location = new Point(574, 90);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(340, 520);
            pnMenu.TabIndex = 3;
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
            tlpMainTitle.Size = new Size(936, 37);
            tlpMainTitle.TabIndex = 10;
            tlpMainTitle.MouseDown += lblTitle_MouseDown;
            tlpMainTitle.MouseMove += lblTitle_MouseMove;
            tlpMainTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(834, 3);
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
            btnMax.Location = new Point(869, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 31);
            btnMax.TabIndex = 2;
            btnMax.Text = "□";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Button;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(904, 3);
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
            // Form_Admin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 650);
            Controls.Add(tlpMainTitle);
            Controls.Add(pnMenu);
            Controls.Add(listMenu);
            Controls.Add(lblEditMenu);
            Controls.Add(lblListMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Admin";
            Text = "커피한잔POS - 관리자(메뉴 관리)";
            ((System.ComponentModel.ISupportInitialize)listMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsMenu).EndInit();
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dsCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsStatus).EndInit();
            tlpMainTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListMenu;
        private Label lblEditMenu;
        private DataGridView listMenu;
        private BindingSource dsMenu;
        private Panel pnMenu;
        private Label lblStatus;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox txtMenuName;
        private Label lblMenuName;
        private TextBox txtPrice;
        private ComboBox cmbStatus;
        private ComboBox cmbCategory;
        private BindingSource dsCategory;
        private BindingSource dsStatus;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TableLayoutPanel tlpMainTitle;
        private Button btnMin;
        private Button btnMax;
        private Button btnClose;
        private Label lblTitle;
    }
}