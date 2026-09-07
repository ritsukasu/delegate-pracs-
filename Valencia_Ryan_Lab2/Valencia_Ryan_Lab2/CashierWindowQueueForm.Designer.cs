namespace Valencia_Ryan_Lab2
{
    partial class CashierWindowQueueForm
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
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListView();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(20, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(20, 60);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(90, 30);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Location = new Point(130, 20);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(203, 342);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CashierWindowQueueForm
            // 
            ClientSize = new Size(360, 390);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView listCashierQueue;
        private System.Windows.Forms.Timer timer1;
    }
}