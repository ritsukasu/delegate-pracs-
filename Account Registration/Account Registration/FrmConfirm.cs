using System;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(txt => StudentInfoClass.GetProgram());
            DelLastName = new DelegateText(txt => StudentInfoClass.GetLastName());
            DelFirstName = new DelegateText(txt => StudentInfoClass.GetFirstName());
            DelMiddleName = new DelegateText(txt => StudentInfoClass.GetMiddleName());
            DelAddress = new DelegateText(txt => StudentInfoClass.GetAddress());

            DelNumAge = new DelegateNumber(number => StudentInfoClass.GetAge());
            DelNumContactNo = new DelegateNumber(number => StudentInfoClass.GetContactNo());
            DelStudNo = new DelegateNumber(number => StudentInfoClass.GetStudentNo());
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}