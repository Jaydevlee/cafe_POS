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
            ((System.ComponentModel.ISupportInitialize)listMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsMenu).BeginInit();
            pnMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsStatus).BeginInit();
            SuspendLayout();
            // 
            // lblListMenu
            // 
            lblListMenu.AutoSize = true;
            lblListMenu.Location = new Point(12, 9);
            lblListMenu.Name = "lblListMenu";
            lblListMenu.Size = new Size(74, 20);
            lblListMenu.TabIndex = 0;
            lblListMenu.Text = "메뉴 목록";
            // 
            // lblEditMenu
            // 
            lblEditMenu.AutoSize = true;
            lblEditMenu.Location = new Point(581, 9);
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
            listMenu.Location = new Point(12, 51);
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
            pnMenu.Location = new Point(574, 52);
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
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 54);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(107, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 54);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(211, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 54);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
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
            // Form_Admin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 650);
            Controls.Add(pnMenu);
            Controls.Add(listMenu);
            Controls.Add(lblEditMenu);
            Controls.Add(lblListMenu);
            Name = "Form_Admin";
            Text = "커피한잔POS - 관리자(메뉴 관리)";
            ((System.ComponentModel.ISupportInitialize)listMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsMenu).EndInit();
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dsCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsStatus).EndInit();
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
    }
}