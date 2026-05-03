namespace Cafe_Pos.Forms
{
    partial class Form_Recipt
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
            lblOrderId = new Label();
            lblDateTime = new Label();
            lstOrderList = new ListBox();
            pnPrice = new Panel();
            lblCharge = new Label();
            lblReceived = new Label();
            lblTotal = new Label();
            lblGreeting = new Label();
            btnClose = new Button();
            tlpTitle = new TableLayoutPanel();
            btnFormClose = new Button();
            lblTitle = new Label();
            pnPrice.SuspendLayout();
            tlpTitle.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.Font = new Font("맑은 고딕", 20F);
            lblOrderId.Location = new Point(0, 37);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(530, 101);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "커피한잔";
            lblOrderId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            lblDateTime.Location = new Point(159, 161);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(196, 25);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "시간날짜";
            lblDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstOrderList
            // 
            lstOrderList.FormattingEnabled = true;
            lstOrderList.Location = new Point(22, 189);
            lstOrderList.Name = "lstOrderList";
            lstOrderList.Size = new Size(469, 184);
            lstOrderList.TabIndex = 2;
            // 
            // pnPrice
            // 
            pnPrice.Controls.Add(lblCharge);
            pnPrice.Controls.Add(lblReceived);
            pnPrice.Controls.Add(lblTotal);
            pnPrice.Location = new Point(205, 389);
            pnPrice.Name = "pnPrice";
            pnPrice.Size = new Size(286, 162);
            pnPrice.TabIndex = 3;
            // 
            // lblCharge
            // 
            lblCharge.Location = new Point(20, 123);
            lblCharge.Name = "lblCharge";
            lblCharge.Size = new Size(196, 25);
            lblCharge.TabIndex = 4;
            lblCharge.Text = "거스름돈:";
            // 
            // lblReceived
            // 
            lblReceived.Location = new Point(20, 62);
            lblReceived.Name = "lblReceived";
            lblReceived.Size = new Size(179, 25);
            lblReceived.TabIndex = 3;
            lblReceived.Text = "받은 금액:";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(20, 14);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(210, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "합계:";
            // 
            // lblGreeting
            // 
            lblGreeting.Font = new Font("맑은 고딕", 14F);
            lblGreeting.Location = new Point(115, 566);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(264, 38);
            lblGreeting.TabIndex = 4;
            lblGreeting.Text = "감사합니다. 빨리 나가";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Location = new Point(0, 639);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(530, 71);
            btnClose.TabIndex = 5;
            btnClose.Text = "닫기";
            btnClose.UseVisualStyleBackColor = true;
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
            tlpTitle.Size = new Size(530, 37);
            tlpTitle.TabIndex = 12;
            tlpTitle.MouseDown += lblTitle_MouseDown;
            tlpTitle.MouseMove += lblTitle_MouseMove;
            tlpTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnFormClose
            // 
            btnFormClose.Location = new Point(498, 3);
            btnFormClose.Name = "btnFormClose";
            btnFormClose.Size = new Size(29, 31);
            btnFormClose.TabIndex = 3;
            btnFormClose.Text = "X";
            btnFormClose.UseVisualStyleBackColor = true;
            btnFormClose.Click += btnFormClose_Clilck;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "결제";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Recipt
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 710);
            Controls.Add(tlpTitle);
            Controls.Add(btnClose);
            Controls.Add(lblGreeting);
            Controls.Add(pnPrice);
            Controls.Add(lstOrderList);
            Controls.Add(lblDateTime);
            Controls.Add(lblOrderId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Recipt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "영수증";
            pnPrice.ResumeLayout(false);
            tlpTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblOrderId;
        private Label lblDateTime;
        private ListBox lstOrderList;
        private Panel pnPrice;
        private Label lblGreeting;
        private Label lblCharge;
        private Label lblReceived;
        private Label lblTotal;
        private Button btnClose;
        private TableLayoutPanel tlpTitle;
        private Button btnFormClose;
        private Label lblTitle;
    }
}