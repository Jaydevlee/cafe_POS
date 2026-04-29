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
            toolSales = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            pnCategory.SuspendLayout();
            pnTotal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolManage });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1026, 28);
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
            menuTool.Size = new Size(224, 26);
            menuTool.Text = "메뉴 관리";
            menuTool.Click += menuTool_Click;
            // 
            // lblOrderList
            // 
            lblOrderList.AutoSize = true;
            lblOrderList.Location = new Point(732, 27);
            lblOrderList.Name = "lblOrderList";
            lblOrderList.Size = new Size(69, 20);
            lblOrderList.TabIndex = 1;
            lblOrderList.Text = "주문내역";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(732, 64);
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
            btnCancel.Location = new Point(732, 488);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(883, 488);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(131, 50);
            btnPurchase.TabIndex = 5;
            btnPurchase.Text = "결제";
            btnPurchase.UseVisualStyleBackColor = true;
            // 
            // pnCategory
            // 
            pnCategory.Controls.Add(btnDessert);
            pnCategory.Controls.Add(btnTea);
            pnCategory.Controls.Add(btnNonCoffee);
            pnCategory.Controls.Add(btnCoffee);
            pnCategory.Location = new Point(0, 27);
            pnCategory.Name = "pnCategory";
            pnCategory.Size = new Size(726, 60);
            pnCategory.TabIndex = 6;
            // 
            // btnDessert
            // 
            btnDessert.Location = new Point(355, 13);
            btnDessert.Name = "btnDessert";
            btnDessert.Size = new Size(104, 35);
            btnDessert.TabIndex = 8;
            btnDessert.Text = "디저트";
            btnDessert.UseVisualStyleBackColor = true;
            // 
            // btnTea
            // 
            btnTea.Location = new Point(245, 13);
            btnTea.Name = "btnTea";
            btnTea.Size = new Size(104, 35);
            btnTea.TabIndex = 7;
            btnTea.Text = "티";
            btnTea.UseVisualStyleBackColor = true;
            // 
            // btnNonCoffee
            // 
            btnNonCoffee.Location = new Point(135, 13);
            btnNonCoffee.Name = "btnNonCoffee";
            btnNonCoffee.Size = new Size(104, 35);
            btnNonCoffee.TabIndex = 6;
            btnNonCoffee.Text = "논커피";
            btnNonCoffee.UseVisualStyleBackColor = true;
            // 
            // btnCoffee
            // 
            btnCoffee.Location = new Point(25, 13);
            btnCoffee.Name = "btnCoffee";
            btnCoffee.Size = new Size(104, 35);
            btnCoffee.TabIndex = 5;
            btnCoffee.Text = "커피";
            btnCoffee.UseVisualStyleBackColor = true;
            // 
            // fplButtons
            // 
            fplButtons.Location = new Point(12, 105);
            fplButtons.Name = "fplButtons";
            fplButtons.Size = new Size(714, 433);
            fplButtons.TabIndex = 7;
            // 
            // pnTotal
            // 
            pnTotal.Controls.Add(displayTotal);
            pnTotal.Controls.Add(lblTotal);
            pnTotal.Location = new Point(732, 395);
            pnTotal.Name = "pnTotal";
            pnTotal.Size = new Size(282, 87);
            pnTotal.TabIndex = 8;
            // 
            // displayTotal
            // 
            displayTotal.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            displayTotal.ForeColor = SystemColors.ControlText;
            displayTotal.Location = new Point(107, 24);
            displayTotal.Name = "displayTotal";
            displayTotal.Size = new Size(159, 49);
            displayTotal.TabIndex = 4;
            displayTotal.Text = "0";
            displayTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolSales
            // 
            toolSales.Name = "toolSales";
            toolSales.Size = new Size(224, 26);
            toolSales.Text = "매출 조회";
            toolSales.Click += toolSales_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 573);
            Controls.Add(pnTotal);
            Controls.Add(fplButtons);
            Controls.Add(pnCategory);
            Controls.Add(btnPurchase);
            Controls.Add(btnCancel);
            Controls.Add(lstOrder);
            Controls.Add(lblOrderList);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Main";
            Text = "커피한잔 POS";
            Load += Form_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnCategory.ResumeLayout(false);
            pnTotal.ResumeLayout(false);
            pnTotal.PerformLayout();
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
    }
}
