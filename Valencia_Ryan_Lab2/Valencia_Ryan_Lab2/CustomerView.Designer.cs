namespace Valencia_Ryan_Lab2
{
    partial class CustomerView
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblNowServingNumber = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "*Now Serving";
            // 
            // lblNowServingNumber
            // 
            lblNowServingNumber.AutoSize = true;
            lblNowServingNumber.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNowServingNumber.Location = new Point(12, 90);
            lblNowServingNumber.Name = "lblNowServingNumber";
            lblNowServingNumber.Size = new Size(0, 65);
            lblNowServingNumber.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 206);
            Controls.Add(lblNowServingNumber);
            Controls.Add(label1);
            Name = "CustomerView";
            Text = "CustomerView";
            Load += CustomerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNowServingNumber;
        private System.Windows.Forms.Timer timer1;
    }
}