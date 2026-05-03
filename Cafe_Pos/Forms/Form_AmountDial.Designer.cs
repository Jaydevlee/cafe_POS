namespace Cafe_Pos.Forms
{
    partial class Form_AmountDial
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
            lblMenu = new Label();
            lblQuantity = new Label();
            btnUp = new Button();
            btnDown = new Button();
            btnRemove = new Button();
            btnSave = new Button();
            tlpTitle = new TableLayoutPanel();
            btnClose = new Button();
            lblTitle = new Label();
            tlpTitle.SuspendLayout();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblMenu.Location = new Point(250, 34);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(202, 70);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "label1";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            lblQuantity.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblQuantity.Location = new Point(280, 120);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(143, 137);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "0";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.FromArgb(215, 204, 200);
            btnUp.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnUp.ForeColor = Color.FromArgb(93, 55, 55);
            btnUp.Location = new Point(449, 139);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(134, 118);
            btnUp.TabIndex = 2;
            btnUp.Text = "+";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.BackColor = Color.FromArgb(215, 204, 200);
            btnDown.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDown.ForeColor = Color.FromArgb(93, 55, 55);
            btnDown.Location = new Point(138, 139);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(117, 112);
            btnDown.TabIndex = 3;
            btnDown.Text = "-";
            btnDown.UseVisualStyleBackColor = false;
            btnDown.Click += btnDown_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(216, 67, 21);
            btnRemove.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(73, 298);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(250, 73);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "항목삭제";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(216, 67, 21);
            btnSave.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(383, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 73);
            btnSave.TabIndex = 5;
            btnSave.Text = "확인";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tlpTitle
            // 
            tlpTitle.BackColor = Color.FromArgb(93, 55, 55);
            tlpTitle.ColumnCount = 4;
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpTitle.Controls.Add(btnClose, 3, 0);
            tlpTitle.Controls.Add(lblTitle, 0, 0);
            tlpTitle.Dock = DockStyle.Top;
            tlpTitle.Location = new Point(0, 0);
            tlpTitle.Name = "tlpTitle";
            tlpTitle.RowCount = 1;
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitle.Size = new Size(721, 41);
            tlpTitle.TabIndex = 6;
            tlpTitle.MouseDown += lblTitle_MouseDown;
            tlpTitle.MouseMove += lblTitle_MouseMove;
            tlpTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(689, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 31);
            btnClose.TabIndex = 4;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("맑은 고딕", 12F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(117, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "수량 조절";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_AmountDial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(tlpTitle);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(lblQuantity);
            Controls.Add(lblMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_AmountDial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "수량 조절";
            tlpTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblMenu;
        private Label lblQuantity;
        private Button btnUp;
        private Button btnDown;
        private Button btnRemove;
        private Button btnSave;
        private TableLayoutPanel tlpTitle;
        private Label lblTitle;
        private Button btnClose;
    }
}