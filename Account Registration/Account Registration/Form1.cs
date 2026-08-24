namespace Account_Registration
{
	public delegate long DelegateNumber(long number);
	public delegate string DelegateText(string txt);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class StudentInfoClass
        {
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string MiddleName = string.Empty;
            string Address = string.Empty;
            string Program = string.Empty;

            long Age = 0;
            long ContactNo = 0;
            long StudentNo = 0;

            public static string GetFirstName() => FirstName;
			public static string GetLastName() => LastName;
            public static string GetMiddleName() => MiddleName;
            public static string GetAddress() => Address;
            public static string GetProgram() => Program;
            public static long GetAge() => Age;
            public static long GetContactNo() => ContactNo;
            public static long GetStudentNo() => StudentNo;

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			StudentInfoClass.FirstName = FirstName.Text;
			StudentInfoClass.MiddleName = MiddleName.Text;
			StudentInfoClass.LastName = LastName.Text;

			StudentInfoClass.Program = cbProgram.Text;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
