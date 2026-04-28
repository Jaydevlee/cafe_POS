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
            lblStore = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStore
            // 
            lblStore.Dock = DockStyle.Top;
            lblStore.Font = new Font("맑은 고딕", 20F);
            lblStore.Location = new Point(0, 0);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(530, 101);
            lblStore.TabIndex = 0;
            lblStore.Text = "커피한잔";
            lblStore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(212, 101);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 1;
            label1.Text = "시간날짜";
            // 
            // Form_Recipt
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 646);
            Controls.Add(label1);
            Controls.Add(lblStore);
            Name = "Form_Recipt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "영수증";
            ResumeLayout(false);
        }

        #endregion

        private Label lblStore;
        private Label label1;
    }
}