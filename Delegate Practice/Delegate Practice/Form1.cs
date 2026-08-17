using System;
using System.Windows.Forms;

public delegate int GetAnswer(int num1, int num2);

class Formula
{
    public static int getSum(int num1, int num2)
    {
        return num1 + num2;
    }
}

namespace DelegatePractice
{
    public partial class Form1 : Form
    {
        GetAnswer delegateAddition;

        public Form1()
        {
            InitializeComponent();
            delegateAddition = new GetAnswer(Formula.getSum);
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            MessageBox.Show(delegateAddition(10, 20).ToString());
        }
    }
}