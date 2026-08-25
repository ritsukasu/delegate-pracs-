namespace CalculatorApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            txtBoxInput2 = new TextBox();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 91);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(119, 142);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "Answer:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(190, 20);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(255, 29);
            txtBoxInput1.TabIndex = 3;
            txtBoxInput1.TextChanged += txtBoxInput1_TextChanged;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(282, 55);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(72, 27);
            cbOperator.TabIndex = 4;
            cbOperator.SelectedIndexChanged += cbOperator_SelectedIndexChanged;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(190, 88);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(255, 29);
            txtBoxInput2.TabIndex = 5;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(190, 142);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(0, 21);
            lblDisplayTotal.TabIndex = 6;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14F);
            btnEqual.Location = new Point(263, 177);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(110, 37);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 249);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(txtBoxInput2);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private TextBox txtBoxInput2;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}