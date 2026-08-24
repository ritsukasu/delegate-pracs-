namespace Valencia_Delegate_Events
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnAdd = new Button();
            btnDiff = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(157, 116);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Number 1:";
            lblNum1.Click += label1_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(157, 150);
            lblNum2.Name = "lblNum2";
            lblNum2.RightToLeft = RightToLeft.No;
            lblNum2.Size = new Size(63, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Number 2:";
            lblNum2.Click += lblNum2_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(237, 113);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 2;
            txtNum1.TextChanged += textBox1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(237, 150);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            txtNum2.TextChanged += textBox2_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(237, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Addition";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDiff
            // 
            btnDiff.Location = new Point(237, 222);
            btnDiff.Name = "btnDiff";
            btnDiff.Size = new Size(75, 23);
            btnDiff.TabIndex = 6;
            btnDiff.Text = "Difference";
            btnDiff.UseVisualStyleBackColor = true;
            btnDiff.Click += btnDiff_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDiff);
            Controls.Add(btnAdd);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnDiff;
    }
}
