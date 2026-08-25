using System;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = ParseLong(txtStudentNo.Text);
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Age = ParseLong(txtAge.Text);
            StudentInfoClass.ContactNo = ParseLong(txtContactNo.Text);
            StudentInfoClass.Address = rtbAddress.Text;

            using (FrmConfirm frmConfirm = new FrmConfirm())
            {
                if (frmConfirm.ShowDialog() == DialogResult.OK)
                {
                    ClearInputs();
                }
            }
        }

        private long ParseLong(string text)
        {
            long.TryParse(text, out long result);
            return result;
        }

        private void ClearInputs()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            rtbAddress.Clear();
            cbProgram.SelectedIndex = -1;
            cbProgram.Text = string.Empty;
        }

        private void lblStudentNo_Click(object sender, EventArgs e) { }
        private void lblProgram_Click(object sender, EventArgs e) { }
        private void lblMiddleName_Click(object sender, EventArgs e) { }
        private void lblAge_Click(object sender, EventArgs e) { }
        private void txtStudentNo_TextChanged(object sender, EventArgs e) { }
        private void txtLastName_TextChanged(object sender, EventArgs e) { }
        private void txtFirstName_TextChanged(object sender, EventArgs e) { }
        private void txtContactNo_TextChanged(object sender, EventArgs e) { }
        private void txtAge_TextChanged(object sender, EventArgs e) { }
        private void txtMiddleName_TextChanged(object sender, EventArgs e) { }
        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}