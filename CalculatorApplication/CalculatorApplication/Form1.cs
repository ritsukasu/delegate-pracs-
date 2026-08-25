namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;

        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);
            string op = cbOperator.SelectedItem?.ToString();

            if (op == "+")
            {
                cal.CalculateEvent += cal.GetSum;
            }
            else if (op == "-")
            {
                cal.CalculateEvent += cal.GetDifference;
            }
            else if (op == "*")
            {
                cal.CalculateEvent += cal.GetProduct;
            }
            else if (op == "/")
            {
                cal.CalculateEvent += cal.GetQuotient;
            }

            var total = cal.RaiseCalculateEvent(num1, num2);
            lblDisplayTotal.Text = total.ToString();

            if (op == "+")
            {
                cal.CalculateEvent -= cal.GetSum;
            }
            else if (op == "-")
            {
                cal.CalculateEvent -= cal.GetDifference;
            }
            else if (op == "*")
            {
                cal.CalculateEvent -= cal.GetProduct;
            }
            else if (op == "/")
            {
                cal.CalculateEvent -= cal.GetQuotient;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}