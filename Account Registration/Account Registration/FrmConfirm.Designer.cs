namespace Account_Registration
{
    partial class FrmConfirm
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

        private void InitializeComponent()
        {
            lblStudentNoCaption = new Label();
            lblStudentNo = new Label();
            lblProgramCaption = new Label();
            lblProgram = new Label();
            lblLastNameCaption = new Label();
            lblLastName = new Label();
            lblFirstNameCaption = new Label();
            lblFirstName = new Label();
            lblMiddleNameCaption = new Label();
            lblMiddleName = new Label();
            lblAgeCaption = new Label();
            lblAge = new Label();
            lblContactNoCaption = new Label();
            lblContactNo = new Label();
            lblAddressCaption = new Label();
            lblAddress = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblStudentNoCaption
            // 
            lblStudentNoCaption.AutoSize = true;
            lblStudentNoCaption.Location = new Point(34, 33);
            lblStudentNoCaption.Name = "lblStudentNoCaption";
            lblStudentNoCaption.Size = new Size(90, 20);
            lblStudentNoCaption.TabIndex = 0;
            lblStudentNoCaption.Text = "Student No.:";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(171, 33);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(13, 20);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = " ";
            // 
            // lblProgramCaption
            // 
            lblProgramCaption.AutoSize = true;
            lblProgramCaption.Location = new Point(34, 73);
            lblProgramCaption.Name = "lblProgramCaption";
            lblProgramCaption.Size = new Size(69, 20);
            lblProgramCaption.TabIndex = 2;
            lblProgramCaption.Text = "Program:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(171, 73);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(13, 20);
            lblProgram.TabIndex = 3;
            lblProgram.Text = " ";
            // 
            // lblLastNameCaption
            // 
            lblLastNameCaption.AutoSize = true;
            lblLastNameCaption.Location = new Point(34, 113);
            lblLastNameCaption.Name = "lblLastNameCaption";
            lblLastNameCaption.Size = new Size(79, 20);
            lblLastNameCaption.TabIndex = 4;
            lblLastNameCaption.Text = "Last name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(171, 113);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(13, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = " ";
            // 
            // lblFirstNameCaption
            // 
            lblFirstNameCaption.AutoSize = true;
            lblFirstNameCaption.Location = new Point(34, 153);
            lblFirstNameCaption.Name = "lblFirstNameCaption";
            lblFirstNameCaption.Size = new Size(80, 20);
            lblFirstNameCaption.TabIndex = 6;
            lblFirstNameCaption.Text = "First name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(171, 153);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(13, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = " ";
            // 
            // lblMiddleNameCaption
            // 
            lblMiddleNameCaption.AutoSize = true;
            lblMiddleNameCaption.Location = new Point(34, 193);
            lblMiddleNameCaption.Name = "lblMiddleNameCaption";
            lblMiddleNameCaption.Size = new Size(103, 20);
            lblMiddleNameCaption.TabIndex = 8;
            lblMiddleNameCaption.Text = "Middle Name:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(171, 193);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(13, 20);
            lblMiddleName.TabIndex = 9;
            lblMiddleName.Text = " ";
            // 
            // lblAgeCaption
            // 
            lblAgeCaption.AutoSize = true;
            lblAgeCaption.Location = new Point(34, 233);
            lblAgeCaption.Name = "lblAgeCaption";
            lblAgeCaption.Size = new Size(39, 20);
            lblAgeCaption.TabIndex = 10;
            lblAgeCaption.Text = "Age:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(171, 233);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(13, 20);
            lblAge.TabIndex = 11;
            lblAge.Text = " ";
            // 
            // lblContactNoCaption
            // 
            lblContactNoCaption.AutoSize = true;
            lblContactNoCaption.Location = new Point(34, 273);
            lblContactNoCaption.Name = "lblContactNoCaption";
            lblContactNoCaption.Size = new Size(90, 20);
            lblContactNoCaption.TabIndex = 12;
            lblContactNoCaption.Text = "Contact No.:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(171, 273);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(13, 20);
            lblContactNo.TabIndex = 13;
            lblContactNo.Text = " ";
            // 
            // lblAddressCaption
            // 
            lblAddressCaption.AutoSize = true;
            lblAddressCaption.Location = new Point(34, 313);
            lblAddressCaption.Name = "lblAddressCaption";
            lblAddressCaption.Size = new Size(65, 20);
            lblAddressCaption.TabIndex = 14;
            lblAddressCaption.Text = "Address:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(171, 313);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(13, 20);
            lblAddress.TabIndex = 15;
            lblAddress.Text = " ";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(228, 381);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(103, 40);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FrmConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(595, 467);
            Controls.Add(lblStudentNoCaption);
            Controls.Add(lblStudentNo);
            Controls.Add(lblProgramCaption);
            Controls.Add(lblProgram);
            Controls.Add(lblLastNameCaption);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstNameCaption);
            Controls.Add(lblFirstName);
            Controls.Add(lblMiddleNameCaption);
            Controls.Add(lblMiddleName);
            Controls.Add(lblAgeCaption);
            Controls.Add(lblAge);
            Controls.Add(lblContactNoCaption);
            Controls.Add(lblContactNo);
            Controls.Add(lblAddressCaption);
            Controls.Add(lblAddress);
            Controls.Add(btnSubmit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConfirm";
            Text = "FrmConfirm";
            FormClosing += FrmConfirm_FormClosing;
            Load += FrmConfirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblStudentNoCaption;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblProgramCaption;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblLastNameCaption;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstNameCaption;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleNameCaption;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblAgeCaption;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContactNoCaption;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblAddressCaption;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSubmit;
    }
}