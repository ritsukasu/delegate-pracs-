using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Valencia_Delegate_Events
{
    public partial class Form1 : Form
    {
        // Delegate that defines the signature for a calculation operation
        private delegate double Calculate(double num1, double num2);

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNum2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Assign the Add method to the delegate and invoke it
            Calculate calc = Add;
            PerformCalculation(calc, "Sum");
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            // Assign the Subtract method to the delegate and invoke it
            Calculate calc = Subtract;
            PerformCalculation(calc, "Difference");
        }

        // Helper method that validates input and runs the delegate
        private void PerformCalculation(Calculate operation, string label)
        {
            if (!double.TryParse(txtNum1.Text, out double num1))
            {
                MessageBox.Show("Please enter a valid number for Number 1.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("Please enter a valid number for Number 2.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = operation(num1, num2);
            MessageBox.Show($"{label}: {result}", "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double Add(double a, double b)
        {
            return a + b;
        }

        private double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}