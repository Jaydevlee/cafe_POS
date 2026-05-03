namespace Cafe_Pos.Forms
{
    partial class Form_Sales
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
            panel1 = new Panel();
            btnSelect = new Button();
            label1 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            lblPreiod = new Label();
            pnOrder = new Panel();
            displayOrders = new Label();
            lblOrders = new Label();
            pnTotal = new Panel();
            displayTotal = new Label();
            lblTotal = new Label();
            pnAvg = new Panel();
            displayAvg = new Label();
            lblAvg = new Label();
            lblTop5 = new Label();
            dgvTop5 = new DataGridView();
            pnDgv = new Panel();
            dsTop5 = new BindingSource(components);
            tlpMainTitle = new TableLayoutPanel();
            btnMin = new Button();
            btnMax = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            panel1.SuspendLayout();
            pnOrder.SuspendLayout();
            pnTotal.SuspendLayout();
            pnAvg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            pnDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsTop5).BeginInit();
            tlpMainTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpEnd);
            panel1.Controls.Add(dtpStart);
            panel1.Controls.Add(lblPreiod);
            panel1.Location = new Point(12, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 74);
            panel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(93, 55, 55);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(463, 19);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(103, 29);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "조회";
            btnSelect.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(259, 21);
            label1.Name = "label1";
            label1.Size = new Size(21, 25);
            label1.TabIndex = 6;
            label1.Text = "~";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(286, 21);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(144, 27);
            dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(107, 21);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(144, 27);
            dtpStart.TabIndex = 4;
            // 
            // lblPreiod
            // 
            lblPreiod.BackColor = Color.Transparent;
            lblPreiod.Location = new Point(22, 26);
            lblPreiod.Name = "lblPreiod";
            lblPreiod.Size = new Size(78, 25);
            lblPreiod.TabIndex = 3;
            lblPreiod.Text = "조회 기간:";
            // 
            // pnOrder
            // 
            pnOrder.Controls.Add(displayOrders);
            pnOrder.Controls.Add(lblOrders);
            pnOrder.Location = new Point(327, 154);
            pnOrder.Name = "pnOrder";
            pnOrder.Size = new Size(280, 128);
            pnOrder.TabIndex = 2;
            // 
            // displayOrders
            // 
            displayOrders.BackColor = Color.Transparent;
            displayOrders.Font = new Font("맑은 고딕", 17F);
            displayOrders.Location = new Point(12, 46);
            displayOrders.Name = "displayOrders";
            displayOrders.Size = new Size(191, 44);
            displayOrders.TabIndex = 6;
            displayOrders.Text = "주문 건수";
            // 
            // lblOrders
            // 
            lblOrders.BackColor = Color.Transparent;
            lblOrders.Location = new Point(12, 11);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(78, 25);
            lblOrders.TabIndex = 4;
            lblOrders.Text = "주문 건수";
            // 
            // pnTotal
            // 
            pnTotal.Controls.Add(displayTotal);
            pnTotal.Controls.Add(lblTotal);
            pnTotal.Location = new Point(12, 154);
            pnTotal.Name = "pnTotal";
            pnTotal.Size = new Size(280, 128);
            pnTotal.TabIndex = 1;
            // 
            // displayTotal
            // 
            displayTotal.BackColor = Color.Transparent;
            displayTotal.Font = new Font("맑은 고딕", 17F);
            displayTotal.Location = new Point(12, 46);
            displayTotal.Name = "displayTotal";
            displayTotal.Size = new Size(191, 44);
            displayTotal.TabIndex = 5;
            displayTotal.Text = "총 매출";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Location = new Point(12, 11);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "총 매출";
            // 
            // pnAvg
            // 
            pnAvg.Controls.Add(displayAvg);
            pnAvg.Controls.Add(lblAvg);
            pnAvg.Location = new Point(654, 154);
            pnAvg.Name = "pnAvg";
            pnAvg.Size = new Size(280, 128);
            pnAvg.TabIndex = 2;
            // 
            // displayAvg
            // 
            displayAvg.BackColor = Color.Transparent;
            displayAvg.Font = new Font("맑은 고딕", 17F);
            displayAvg.Location = new Point(13, 46);
            displayAvg.Name = "displayAvg";
            displayAvg.Size = new Size(191, 44);
            displayAvg.TabIndex = 6;
            displayAvg.Text = "평균 금액";
            // 
            // lblAvg
            // 
            lblAvg.BackColor = Color.Transparent;
            lblAvg.Location = new Point(13, 11);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(110, 25);
            lblAvg.TabIndex = 5;
            lblAvg.Text = "평균 주문 금액";
            // 
            // lblTop5
            // 
            lblTop5.BackColor = Color.Transparent;
            lblTop5.Location = new Point(12, 310);
            lblTop5.Name = "lblTop5";
            lblTop5.Size = new Size(131, 25);
            lblTop5.TabIndex = 4;
            lblTop5.Text = "인기 메뉴 TOP 5";
            // 
            // dgvTop5
            // 
            dgvTop5.BackgroundColor = Color.WhiteSmoke;
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Location = new Point(0, 0);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.RowHeadersWidth = 51;
            dgvTop5.Size = new Size(922, 298);
            dgvTop5.TabIndex = 5;
            // 
            // pnDgv
            // 
            pnDgv.Controls.Add(dgvTop5);
            pnDgv.Location = new Point(12, 347);
            pnDgv.Name = "pnDgv";
            pnDgv.Size = new Size(922, 301);
            pnDgv.TabIndex = 6;
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
            tlpMainTitle.Size = new Size(946, 37);
            tlpMainTitle.TabIndex = 11;
            tlpMainTitle.MouseDown += lblTitle_MouseDown;
            tlpMainTitle.MouseMove += lblTitle_MouseMove;
            tlpMainTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(844, 3);
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
            btnMax.Location = new Point(879, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 31);
            btnMax.TabIndex = 2;
            btnMax.Text = "□";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Button;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(914, 3);
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
            lblTitle.Size = new Size(228, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "☕커피한잔 POS - 매출조회";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Sales
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 718);
            Controls.Add(tlpMainTitle);
            Controls.Add(pnDgv);
            Controls.Add(lblTop5);
            Controls.Add(pnOrder);
            Controls.Add(pnAvg);
            Controls.Add(pnTotal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Sales";
            Text = "커피한잔POS - 매출 조회";
            panel1.ResumeLayout(false);
            pnOrder.ResumeLayout(false);
            pnTotal.ResumeLayout(false);
            pnAvg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            pnDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dsTop5).EndInit();
            tlpMainTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnOrder;
        private Panel pnTotal;
        private Panel pnAvg;
        private Label lblPreiod;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label1;
        private Button btnSelect;
        private Label lblTop5;
        private DataGridView dgvTop5;
        private Panel pnDgv;
        private Label lblOrders;
        private Label displayTotal;
        private Label lblTotal;
        private Label lblAvg;
        private Label displayOrders;
        private Label displayAvg;
        private BindingSource dsTop5;
        private TableLayoutPanel tlpMainTitle;
        private Button btnMin;
        private Button btnMax;
        private Button btnClose;
        private Label lblTitle;
    }
}