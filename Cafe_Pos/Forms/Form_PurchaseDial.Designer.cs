namespace Cafe_Pos.Forms
{
    partial class Form_PurchaseDial
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
            lblOrder = new Label();
            lstOrder = new ListBox();
            pnPrice = new Panel();
            displayTotal = new Label();
            lblTotal = new Label();
            lblRecived = new Label();
            textRecived = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClear = new Button();
            btnPrice = new Button();
            btn1 = new Button();
            btn5 = new Button();
            btn10 = new Button();
            lblCharge = new Label();
            displayCharge = new Label();
            btnCancel = new Button();
            btnPayment = new Button();
            label1 = new Label();
            pnPrice.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrder
            // 
            lblOrder.Location = new Point(0, 0);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(78, 25);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "주문 상품";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(12, 36);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(573, 144);
            lstOrder.TabIndex = 1;
            // 
            // pnPrice
            // 
            pnPrice.Controls.Add(displayTotal);
            pnPrice.Controls.Add(lblTotal);
            pnPrice.Location = new Point(12, 198);
            pnPrice.Name = "pnPrice";
            pnPrice.Size = new Size(573, 66);
            pnPrice.TabIndex = 2;
            // 
            // displayTotal
            // 
            displayTotal.Location = new Point(421, 11);
            displayTotal.Name = "displayTotal";
            displayTotal.Size = new Size(129, 44);
            displayTotal.TabIndex = 4;
            displayTotal.Text = "0원";
            displayTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(15, 23);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 25);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "결제 금액";
            // 
            // lblRecived
            // 
            lblRecived.Location = new Point(12, 304);
            lblRecived.Name = "lblRecived";
            lblRecived.Size = new Size(78, 25);
            lblRecived.TabIndex = 4;
            lblRecived.Text = "받은 금액";
            // 
            // textRecived
            // 
            textRecived.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textRecived.Location = new Point(225, 282);
            textRecived.Name = "textRecived";
            textRecived.Size = new Size(294, 47);
            textRecived.TabIndex = 5;
            textRecived.Text = "0";
            textRecived.TextAlign = HorizontalAlignment.Right;
            textRecived.KeyDown += textRecived_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.2427654F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9393082F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9393082F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9393082F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9393082F));
            tableLayoutPanel1.Controls.Add(btnClear, 4, 0);
            tableLayoutPanel1.Controls.Add(btnPrice, 3, 0);
            tableLayoutPanel1.Controls.Add(btn1, 2, 0);
            tableLayoutPanel1.Controls.Add(btn5, 1, 0);
            tableLayoutPanel1.Controls.Add(btn10, 0, 0);
            tableLayoutPanel1.Location = new Point(15, 354);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(570, 50);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(457, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 44);
            btnClear.TabIndex = 4;
            btnClear.Text = "지움";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnPrice
            // 
            btnPrice.Location = new Point(344, 3);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(107, 44);
            btnPrice.TabIndex = 3;
            btnPrice.Text = "딱맞게";
            btnPrice.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(231, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 44);
            btn1.TabIndex = 2;
            btn1.Text = "+1천";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(118, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(107, 44);
            btn5.TabIndex = 1;
            btn5.Text = "+5천";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Location = new Point(3, 3);
            btn10.Name = "btn10";
            btn10.Size = new Size(109, 44);
            btn10.TabIndex = 0;
            btn10.Text = "+1만";
            btn10.UseVisualStyleBackColor = true;
            // 
            // lblCharge
            // 
            lblCharge.Location = new Point(15, 441);
            lblCharge.Name = "lblCharge";
            lblCharge.Size = new Size(78, 25);
            lblCharge.TabIndex = 7;
            lblCharge.Text = "거스름돈";
            // 
            // displayCharge
            // 
            displayCharge.Location = new Point(423, 429);
            displayCharge.Name = "displayCharge";
            displayCharge.Size = new Size(129, 44);
            displayCharge.TabIndex = 5;
            displayCharge.Text = "0원";
            displayCharge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(15, 492);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(296, 61);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(317, 492);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(268, 61);
            btnPayment.TabIndex = 9;
            btnPayment.Text = "결제완료";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(525, 288);
            label1.Name = "label1";
            label1.Size = new Size(48, 41);
            label1.TabIndex = 10;
            label1.Text = "원";
            // 
            // Form_PurchaseDial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 593);
            Controls.Add(label1);
            Controls.Add(btnPayment);
            Controls.Add(btnCancel);
            Controls.Add(displayCharge);
            Controls.Add(lblCharge);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textRecived);
            Controls.Add(lblRecived);
            Controls.Add(pnPrice);
            Controls.Add(lstOrder);
            Controls.Add(lblOrder);
            Name = "Form_PurchaseDial";
            Text = "결제";
            pnPrice.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrder;
        private ListBox lstOrder;
        private Panel pnPrice;
        private Label lblTotal;
        private Label lblRecived;
        private Label displayTotal;
        private TextBox textRecived;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCharge;
        private Label displayCharge;
        private Button btnCancel;
        private Button btnPayment;
        private Label label1;
        private Button btnClear;
        private Button btnPrice;
        private Button btn1;
        private Button btn5;
        private Button btn10;
    }
}