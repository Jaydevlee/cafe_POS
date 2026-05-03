namespace Cafe_Pos
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolManage = new ToolStripMenuItem();
            menuTool = new ToolStripMenuItem();
            toolSales = new ToolStripMenuItem();
            lblOrderList = new Label();
            lstOrder = new ListBox();
            lblTotal = new Label();
            btnCancel = new Button();
            btnPurchase = new Button();
            pnCategory = new Panel();
            btnDessert = new Button();
            btnTea = new Button();
            btnNonCoffee = new Button();
            btnCoffee = new Button();
            fplButtons = new FlowLayoutPanel();
            pnTotal = new Panel();
            displayTotal = new Label();
            tlpMainTitle = new TableLayoutPanel();
            btnMin = new Button();
            btnMax = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            menuStrip1.SuspendLayout();
            pnCategory.SuspendLayout();
            pnTotal.SuspendLayout();
            tlpMainTitle.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolManage });
            menuStrip1.Location = new Point(0, 36);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(61, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolManage
            // 
            toolManage.DropDownItems.AddRange(new ToolStripItem[] { menuTool, toolSales });
            toolManage.Name = "toolManage";
            toolManage.Size = new Size(53, 24);
            toolManage.Text = "관리";
            // 
            // menuTool
            // 
            menuTool.Name = "menuTool";
            menuTool.Size = new Size(157, 26);
            menuTool.Text = "메뉴 관리";
            menuTool.Click += menuTool_Click;
            // 
            // toolSales
            // 
            toolSales.Name = "toolSales";
            toolSales.Size = new Size(157, 26);
            toolSales.Text = "매출 조회";
            toolSales.Click += toolSales_Click;
            // 
            // lblOrderList
            // 
            lblOrderList.AutoSize = true;
            lblOrderList.Font = new Font("맑은 고딕", 15F);
            lblOrderList.ForeColor = Color.FromArgb(93, 55, 55);
            lblOrderList.Location = new Point(732, 63);
            lblOrderList.Name = "lblOrderList";
            lblOrderList.Size = new Size(115, 35);
            lblOrderList.TabIndex = 1;
            lblOrderList.Text = "주문내역";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(732, 100);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(282, 324);
            lstOrder.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(11, 11);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "합계";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(215, 204, 200);
            btnCancel.ForeColor = Color.FromArgb(93, 55, 55);
            btnCancel.Location = new Point(732, 524);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.FromArgb(216, 67, 21);
            btnPurchase.ForeColor = Color.WhiteSmoke;
            btnPurchase.Location = new Point(883, 524);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(131, 50);
            btnPurchase.TabIndex = 5;
            btnPurchase.Text = "결제";
            btnPurchase.UseVisualStyleBackColor = false;
            // 
            // pnCategory
            // 
            pnCategory.Controls.Add(btnDessert);
            pnCategory.Controls.Add(btnTea);
            pnCategory.Controls.Add(btnNonCoffee);
            pnCategory.Controls.Add(btnCoffee);
            pnCategory.Location = new Point(0, 63);
            pnCategory.Name = "pnCategory";
            pnCategory.Size = new Size(726, 60);
            pnCategory.TabIndex = 6;
            // 
            // btnDessert
            // 
            btnDessert.BackColor = Color.FromArgb(215, 204, 200);
            btnDessert.ForeColor = Color.FromArgb(93, 55, 55);
            btnDessert.Location = new Point(355, 13);
            btnDessert.Name = "btnDessert";
            btnDessert.Size = new Size(104, 35);
            btnDessert.TabIndex = 8;
            btnDessert.Text = "디저트";
            btnDessert.UseVisualStyleBackColor = false;
            // 
            // btnTea
            // 
            btnTea.BackColor = Color.FromArgb(215, 204, 200);
            btnTea.ForeColor = Color.FromArgb(93, 55, 55);
            btnTea.Location = new Point(245, 13);
            btnTea.Name = "btnTea";
            btnTea.Size = new Size(104, 35);
            btnTea.TabIndex = 7;
            btnTea.Text = "티";
            btnTea.UseVisualStyleBackColor = false;
            // 
            // btnNonCoffee
            // 
            btnNonCoffee.BackColor = Color.FromArgb(215, 204, 200);
            btnNonCoffee.ForeColor = Color.FromArgb(93, 55, 55);
            btnNonCoffee.Location = new Point(135, 13);
            btnNonCoffee.Name = "btnNonCoffee";
            btnNonCoffee.Size = new Size(104, 35);
            btnNonCoffee.TabIndex = 6;
            btnNonCoffee.Text = "논커피";
            btnNonCoffee.UseVisualStyleBackColor = false;
            // 
            // btnCoffee
            // 
            btnCoffee.BackColor = Color.FromArgb(215, 204, 200);
            btnCoffee.ForeColor = Color.FromArgb(93, 55, 55);
            btnCoffee.Location = new Point(25, 13);
            btnCoffee.Name = "btnCoffee";
            btnCoffee.Size = new Size(104, 35);
            btnCoffee.TabIndex = 5;
            btnCoffee.Text = "커피";
            btnCoffee.UseVisualStyleBackColor = false;
            // 
            // fplButtons
            // 
            fplButtons.Location = new Point(12, 141);
            fplButtons.Name = "fplButtons";
            fplButtons.Size = new Size(714, 433);
            fplButtons.TabIndex = 7;
            // 
            // pnTotal
            // 
            pnTotal.BackColor = Color.FromArgb(251, 233, 231);
            pnTotal.Controls.Add(displayTotal);
            pnTotal.Controls.Add(lblTotal);
            pnTotal.Location = new Point(732, 431);
            pnTotal.Name = "pnTotal";
            pnTotal.Size = new Size(282, 87);
            pnTotal.TabIndex = 8;
            // 
            // displayTotal
            // 
            displayTotal.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            displayTotal.ForeColor = Color.FromArgb(216, 67, 21);
            displayTotal.Location = new Point(107, 24);
            displayTotal.Name = "displayTotal";
            displayTotal.Size = new Size(159, 49);
            displayTotal.TabIndex = 4;
            displayTotal.Text = "0";
            displayTotal.TextAlign = ContentAlignment.MiddleRight;
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
            tlpMainTitle.Size = new Size(1026, 37);
            tlpMainTitle.TabIndex = 9;
            tlpMainTitle.MouseDown += lblTitle_MouseDown;
            tlpMainTitle.MouseMove += lblTitle_MouseMove;
            tlpMainTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(924, 3);
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
            btnMax.Location = new Point(959, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 31);
            btnMax.TabIndex = 2;
            btnMax.Text = "□";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Button;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(994, 3);
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
            lblTitle.Size = new Size(156, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "☕커피한잔 POS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1026, 652);
            Controls.Add(tlpMainTitle);
            Controls.Add(pnTotal);
            Controls.Add(fplButtons);
            Controls.Add(pnCategory);
            Controls.Add(btnPurchase);
            Controls.Add(btnCancel);
            Controls.Add(lstOrder);
            Controls.Add(lblOrderList);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form_Main";
            Text = "커피한잔 POS";
            Load += Form_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnCategory.ResumeLayout(false);
            pnTotal.ResumeLayout(false);
            pnTotal.PerformLayout();
            tlpMainTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label lblOrderList;
        private ListBox lstOrder;
        private Label lblTotal;
        private Button btnCancel;
        private Button btnPurchase;
        private Panel pnCategory;
        private Button btnDessert;
        private Button btnTea;
        private Button btnNonCoffee;
        private Button btnCoffee;
        private FlowLayoutPanel fplButtons;
        private Panel pnTotal;
        private Label displayTotal;
        private ToolStripMenuItem toolManage;
        private ToolStripMenuItem menuTool;
        private ToolStripMenuItem toolSales;
        private TableLayoutPanel tlpMainTitle;
        private Label lblTitle;
        private Button btnMin;
        private Button btnMax;
        private Button btnClose;
    }
}
