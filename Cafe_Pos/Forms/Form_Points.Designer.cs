namespace Cafe_Pos.Forms
{
    partial class Form_Points
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
            tlpTitle = new TableLayoutPanel();
            btnFormClose = new Button();
            lblTitle = new Label();
            lblAddPoint = new Label();
            txtPhone = new TextBox();
            btnInsertMem = new Button();
            btnAddPoints = new Button();
            btnSkip = new Button();
            tlpTitle.SuspendLayout();
            SuspendLayout();
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
            tlpTitle.Size = new Size(641, 37);
            tlpTitle.TabIndex = 13;
            tlpTitle.MouseDown += lblTitle_MouseDown;
            tlpTitle.MouseMove += lblTitle_MouseMove;
            tlpTitle.MouseUp += lblTitle_MouseUp;
            // 
            // btnFormClose
            // 
            btnFormClose.Location = new Point(609, 3);
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
            lblTitle.Text = "포인트 적립";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddPoint
            // 
            lblAddPoint.AutoSize = true;
            lblAddPoint.Font = new Font("맑은 고딕", 20F);
            lblAddPoint.Location = new Point(91, 102);
            lblAddPoint.Name = "lblAddPoint";
            lblAddPoint.Size = new Size(456, 46);
            lblAddPoint.TabIndex = 14;
            lblAddPoint.Text = "포인트를 적립하시겠습니까?";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("맑은 고딕", 15F);
            txtPhone.Location = new Point(141, 192);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(350, 41);
            txtPhone.TabIndex = 15;
            // 
            // btnInsertMem
            // 
            btnInsertMem.BackColor = Color.LimeGreen;
            btnInsertMem.Location = new Point(91, 297);
            btnInsertMem.Name = "btnInsertMem";
            btnInsertMem.Size = new Size(145, 49);
            btnInsertMem.TabIndex = 16;
            btnInsertMem.Text = "회원가입";
            btnInsertMem.UseVisualStyleBackColor = false;
            // 
            // btnAddPoints
            // 
            btnAddPoints.BackColor = Color.CornflowerBlue;
            btnAddPoints.Location = new Point(251, 297);
            btnAddPoints.Name = "btnAddPoints";
            btnAddPoints.Size = new Size(145, 49);
            btnAddPoints.TabIndex = 17;
            btnAddPoints.Text = "적립하기";
            btnAddPoints.UseVisualStyleBackColor = false;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.FromArgb(216, 67, 21);
            btnSkip.ForeColor = SystemColors.ControlText;
            btnSkip.Location = new Point(415, 297);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(145, 49);
            btnSkip.TabIndex = 18;
            btnSkip.Text = "건너뛰기";
            btnSkip.UseVisualStyleBackColor = false;
            // 
            // Form_Points
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 450);
            Controls.Add(btnSkip);
            Controls.Add(btnAddPoints);
            Controls.Add(btnInsertMem);
            Controls.Add(txtPhone);
            Controls.Add(lblAddPoint);
            Controls.Add(tlpTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Points";
            Text = "Form_Points";
            tlpTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpTitle;
        private Button btnFormClose;
        private Label lblTitle;
        private Label lblAddPoint;
        private TextBox txtPhone;
        private Button btnInsertMem;
        private Button btnAddPoints;
        private Button btnSkip;
    }
}