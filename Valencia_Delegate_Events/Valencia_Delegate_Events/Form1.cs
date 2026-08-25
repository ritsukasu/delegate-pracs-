using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Valencia_Delegate_Events
{
    public partial class Form1 : Form
    {

        private delegate int MathOp(int num1, int num2);

        public Form1()
        {
            InitializeComponent();
        }
        public class Calculator
        {
            public int Add(int num1, int num2)
            {
                return num1 + num2;
            }
            public int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }
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
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            var calc = new Calculator();
            MathOp mathDelegate = new MathOp(calc.Add);
            int result = mathDelegate(num1, num2);
            MessageBox.Show("Answer: " + result.ToString());
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            var calc = new Calculator();
            MathOp mathDelegate = new MathOp(calc.Subtract);
            int result = mathDelegate(num1, num2);
            MessageBox.Show("Answer: " + result.ToString());
        }

    }
}