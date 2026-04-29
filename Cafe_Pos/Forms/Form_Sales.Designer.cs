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
            panel1 = new Panel();
            pnOrder = new Panel();
            pnTotal = new Panel();
            pnAvg = new Panel();
            lblPreiod = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label1 = new Label();
            btnSelect = new Button();
            lblTop5 = new Label();
            dgvTop5 = new DataGridView();
            pnDgv = new Panel();
            lblTotal = new Label();
            lblOrders = new Label();
            lblAvg = new Label();
            displayTotal = new Label();
            displayOrders = new Label();
            displayAvg = new Label();
            panel1.SuspendLayout();
            pnOrder.SuspendLayout();
            pnTotal.SuspendLayout();
            pnAvg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            pnDgv.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpEnd);
            panel1.Controls.Add(dtpStart);
            panel1.Controls.Add(lblPreiod);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 74);
            panel1.TabIndex = 0;
            // 
            // pnOrder
            // 
            pnOrder.Controls.Add(displayOrders);
            pnOrder.Controls.Add(lblOrders);
            pnOrder.Location = new Point(334, 108);
            pnOrder.Name = "pnOrder";
            pnOrder.Size = new Size(280, 128);
            pnOrder.TabIndex = 2;
            // 
            // pnTotal
            // 
            pnTotal.Controls.Add(displayTotal);
            pnTotal.Controls.Add(lblTotal);
            pnTotal.Location = new Point(12, 108);
            pnTotal.Name = "pnTotal";
            pnTotal.Size = new Size(280, 128);
            pnTotal.TabIndex = 1;
            // 
            // pnAvg
            // 
            pnAvg.Controls.Add(displayAvg);
            pnAvg.Controls.Add(lblAvg);
            pnAvg.Location = new Point(654, 108);
            pnAvg.Name = "pnAvg";
            pnAvg.Size = new Size(280, 128);
            pnAvg.TabIndex = 2;
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
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(107, 21);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(144, 27);
            dtpStart.TabIndex = 4;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(286, 21);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(144, 27);
            dtpEnd.TabIndex = 5;
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
            // btnSelect
            // 
            btnSelect.Location = new Point(463, 19);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(103, 29);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "조회";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // lblTop5
            // 
            lblTop5.BackColor = Color.Transparent;
            lblTop5.Location = new Point(12, 260);
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
            pnDgv.Location = new Point(12, 288);
            pnDgv.Name = "pnDgv";
            pnDgv.Size = new Size(922, 301);
            pnDgv.TabIndex = 6;
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
            // lblOrders
            // 
            lblOrders.BackColor = Color.Transparent;
            lblOrders.Location = new Point(12, 11);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(78, 25);
            lblOrders.TabIndex = 4;
            lblOrders.Text = "주문 건수";
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
            // Form_Sales
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 601);
            Controls.Add(pnDgv);
            Controls.Add(lblTop5);
            Controls.Add(pnOrder);
            Controls.Add(pnAvg);
            Controls.Add(pnTotal);
            Controls.Add(panel1);
            Name = "Form_Sales";
            Text = "커피한잔POS - 매출 조회";
            panel1.ResumeLayout(false);
            pnOrder.ResumeLayout(false);
            pnTotal.ResumeLayout(false);
            pnAvg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            pnDgv.ResumeLayout(false);
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
    }
}