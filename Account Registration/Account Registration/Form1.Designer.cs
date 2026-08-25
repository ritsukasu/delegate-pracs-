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
            lblStudentNo = new Label();
            lblProgram = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblAge = new Label();
            lblContactNo = new Label();
            lblSpacer = new Label();
            lblAddress = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtContactNo = new TextBox();
            txtAge = new TextBox();
            txtMiddleName = new TextBox();
            rtbAddress = new RichTextBox();
            btnNext = new Button();
            cbProgram = new ComboBox();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(35, 28);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(73, 15);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No.:";
            lblStudentNo.Click += lblStudentNo_Click;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(208, 28);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(53, 15);
            lblProgram.TabIndex = 1;
            lblProgram.Text = "Program";
            lblProgram.Click += lblProgram_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(35, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(208, 93);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(383, 93);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.RightToLeft = RightToLeft.No;
            lblMiddleName.Size = new Size(79, 15);
            lblMiddleName.TabIndex = 4;
            lblMiddleName.Text = "Middle Name";
            lblMiddleName.Click += lblMiddleName_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(35, 149);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            lblAge.Click += lblAge_Click;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(208, 149);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(74, 15);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "Contact No.:";
            // 
            // lblSpacer
            // 
            lblSpacer.AutoSize = true;
            lblSpacer.Location = new Point(427, 179);
            lblSpacer.Name = "lblSpacer";
            lblSpacer.Size = new Size(0, 15);
            lblSpacer.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(35, 217);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(35, 54);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(160, 23);
            txtStudentNo.TabIndex = 9;
            txtStudentNo.TextChanged += txtStudentNo_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(35, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(160, 23);
            txtLastName.TabIndex = 11;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(208, 111);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 23);
            txtFirstName.TabIndex = 13;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(208, 171);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(160, 23);
            txtContactNo.TabIndex = 14;
            txtContactNo.TextChanged += txtContactNo_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(35, 171);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(160, 23);
            txtAge.TabIndex = 15;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(383, 111);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(160, 23);
            txtMiddleName.TabIndex = 16;
            txtMiddleName.TextChanged += txtMiddleName_TextChanged;
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(35, 235);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(594, 117);
            rtbAddress.TabIndex = 18;
            rtbAddress.Text = "";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(293, 358);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 19;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.BottomCenter;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Computer Science (BSCS)", "BS in Civil Engineering (BSCE)", "BS in Mechanical Engineering (BSME)", "BS in Electrical Engineering (BSEE)", "BS in Accountancy (BSA)", "BS in Management Accounting (BSMA)", "BS in Business Administration (Financial/Marketing Management)", "BS in Hospitality Management (BSHM)", "BS in Tourism Management (BSTM)", "BS in Elementary Education (BEEd)", "BS in Secondary Education (BSEd)", "BS in Physical Education (BPEd)", "BS in Early Childhood Education (BECEd)", "BS in Special Needs Education (BSNEd)", "Bachelor of Arts in Communication (BA Comm)", "Bachelor of Arts in English Language (BAEL)", "BS in Psychology (BS Psych)", "BS in Mathematics (BS Math)", "BS in Criminology (BS Crim)" });
            cbProgram.Location = new Point(208, 54);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(421, 23);
            cbProgram.TabIndex = 20;
            cbProgram.SelectedIndexChanged += cbProgram_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 413);
            Controls.Add(cbProgram);
            Controls.Add(btnNext);
            Controls.Add(rtbAddress);
            Controls.Add(txtMiddleName);
            Controls.Add(txtAge);
            Controls.Add(txtContactNo);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(lblAddress);
            Controls.Add(lblSpacer);
            Controls.Add(lblContactNo);
            Controls.Add(lblAge);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblProgram);
            Controls.Add(lblStudentNo);
            Name = "Form1";
            Text = "FrmRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentNo;
        private Label lblProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblAge;
        private Label lblContactNo;
        private Label lblSpacer;
        private Label lblAddress;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtContactNo;
        private TextBox txtAge;
        private TextBox txtMiddleName;
        private RichTextBox rtbAddress;
        private Button btnNext;
        private ComboBox cbProgram;
    }
}