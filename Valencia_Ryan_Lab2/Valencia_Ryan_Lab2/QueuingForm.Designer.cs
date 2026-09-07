namespace Valencia_Ryan_Lab2
{
    partial class QueuingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnCashier = new Button();
            lblQueue = new Label();
            lblPosition = new Label();
            lblClickNote = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(20, 40);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(120, 100);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(165, 80);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(176, 47);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P - 10000";
            lblQueue.Click += lblQueue_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPosition.Location = new Point(178, 49);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(146, 21);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Position in Queue";
            // 
            // lblClickNote
            // 
            lblClickNote.AutoSize = true;
            lblClickNote.ForeColor = Color.Red;
            lblClickNote.Location = new Point(20, 153);
            lblClickNote.Name = "lblClickNote";
            lblClickNote.Size = new Size(126, 15);
            lblClickNote.TabIndex = 3;
            lblClickNote.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            ClientSize = new Size(366, 206);
            Controls.Add(lblClickNote);
            Controls.Add(lblPosition);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblClickNote;
    }
}