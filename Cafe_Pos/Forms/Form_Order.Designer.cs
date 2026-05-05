namespace Cafe_Pos.Forms
{
    partial class Form_Order
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
            tlpMainTitle = new TableLayoutPanel();
            btnMin = new Button();
            btnMax = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            dgvOrders = new DataGridView();
            lblOrder = new Label();
            lblOrderItem = new Label();
            dgvOrderItem = new DataGridView();
            dsOrders = new BindingSource(components);
            dsOrderItems = new BindingSource(components);
            tlpMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsOrderItems).BeginInit();
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
            tlpMainTitle.Size = new Size(816, 37);
            tlpMainTitle.TabIndex = 11;
            tlpMainTitle.MouseDown += lblTitle_MouseDown;
            tlpMainTitle.MouseMove += lblTitle_MouseMove;
            tlpMainTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(714, 3);
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
            btnMax.Location = new Point(749, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 31);
            btnMax.TabIndex = 2;
            btnMax.Text = "□";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Button;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(784, 3);
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
            lblTitle.Text = "☕커피한잔 POS - 주문관리";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.BackgroundColor = Color.WhiteSmoke;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 79);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(792, 282);
            dgvOrders.TabIndex = 12;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(12, 56);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(69, 20);
            lblOrder.TabIndex = 13;
            lblOrder.Text = "주문내역";
            // 
            // lblOrderItem
            // 
            lblOrderItem.AutoSize = true;
            lblOrderItem.Location = new Point(12, 374);
            lblOrderItem.Name = "lblOrderItem";
            lblOrderItem.Size = new Size(69, 20);
            lblOrderItem.TabIndex = 14;
            lblOrderItem.Text = "주문상세";
            // 
            // dgvOrderItem
            // 
            dgvOrderItem.BackgroundColor = Color.WhiteSmoke;
            dgvOrderItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItem.Location = new Point(12, 406);
            dgvOrderItem.Name = "dgvOrderItem";
            dgvOrderItem.RowHeadersWidth = 51;
            dgvOrderItem.Size = new Size(792, 252);
            dgvOrderItem.TabIndex = 15;
            // 
            // Form_Order
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 710);
            Controls.Add(dgvOrderItem);
            Controls.Add(lblOrderItem);
            Controls.Add(lblOrder);
            Controls.Add(dgvOrders);
            Controls.Add(tlpMainTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Order";
            Text = "Form_Order";
            tlpMainTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpMainTitle;
        private Button btnMin;
        private Button btnMax;
        private Button btnClose;
        private Label lblTitle;
        private DataGridView dgvOrders;
        private Label lblOrder;
        private Label lblOrderItem;
        private DataGridView dgvOrderItem;
        private BindingSource dsOrders;
        private BindingSource dsOrderItems;
    }
}