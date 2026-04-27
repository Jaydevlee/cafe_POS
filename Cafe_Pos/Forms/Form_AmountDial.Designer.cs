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
            btnUp.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnUp.Location = new Point(449, 139);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(134, 118);
            btnUp.TabIndex = 2;
            btnUp.Text = "+";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDown.Location = new Point(138, 139);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(117, 112);
            btnDown.TabIndex = 3;
            btnDown.Text = "-";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(73, 298);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(250, 73);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "항목삭제";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSave.Location = new Point(383, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 73);
            btnSave.TabIndex = 5;
            btnSave.Text = "확인";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form_AmountDial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(lblQuantity);
            Controls.Add(lblMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form_AmountDial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "수량 조절";
            ResumeLayout(false);
        }

        #endregion

        private Label lblMenu;
        private Label lblQuantity;
        private Button btnUp;
        private Button btnDown;
        private Button btnRemove;
        private Button btnSave;
    }
}