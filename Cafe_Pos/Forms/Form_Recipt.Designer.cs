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
            pnPrice.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.Dock = DockStyle.Top;
            lblOrderId.Font = new Font("맑은 고딕", 20F);
            lblOrderId.Location = new Point(0, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(530, 101);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "커피한잔";
            lblOrderId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            lblDateTime.Location = new Point(166, 101);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(196, 25);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "시간날짜";
            lblDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstOrderList
            // 
            lstOrderList.FormattingEnabled = true;
            lstOrderList.Location = new Point(29, 129);
            lstOrderList.Name = "lstOrderList";
            lstOrderList.Size = new Size(469, 184);
            lstOrderList.TabIndex = 2;
            // 
            // pnPrice
            // 
            pnPrice.Controls.Add(lblCharge);
            pnPrice.Controls.Add(lblReceived);
            pnPrice.Controls.Add(lblTotal);
            pnPrice.Location = new Point(212, 329);
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
            lblGreeting.Location = new Point(122, 506);
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
            // Form_Recipt
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 710);
            Controls.Add(btnClose);
            Controls.Add(lblGreeting);
            Controls.Add(pnPrice);
            Controls.Add(lstOrderList);
            Controls.Add(lblDateTime);
            Controls.Add(lblOrderId);
            Name = "Form_Recipt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "영수증";
            pnPrice.ResumeLayout(false);
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
    }
}