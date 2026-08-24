namespace Account_Registration
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
            StudentNo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            cbProgram = new ComboBox();
            SuspendLayout();
            // 
            // StudentNo
            // 
            StudentNo.AutoSize = true;
            StudentNo.Location = new Point(35, 28);
            StudentNo.Name = "StudentNo";
            StudentNo.Size = new Size(73, 15);
            StudentNo.TabIndex = 0;
            StudentNo.Text = "Student No.:";
            StudentNo.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 28);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Program";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 93);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 93);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 93);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Middle Name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 149);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 5;
            label6.Text = "Age";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 149);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 179);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 217);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 8;
            label9.Text = "Address";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(208, 171);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(160, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(35, 171);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(383, 111);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(160, 23);
            textBox7.TabIndex = 16;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(35, 235);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(508, 181);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(261, 433);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Next";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(208, 54);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(160, 23);
            cbProgram.TabIndex = 20;
            cbProgram.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 482);
            Controls.Add(cbProgram);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StudentNo);
            Name = "Form1";
            Text = "FrmRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentNo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private RichTextBox richTextBox1;
        private Button button1;
        private ComboBox cbProgram;
    }
}
