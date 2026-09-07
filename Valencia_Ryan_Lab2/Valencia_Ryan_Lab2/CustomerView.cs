using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Valencia_Ryan_Lab2
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue?.Count > 0)
            {
                string frontNumber = CashierClass.CashierQueue.Peek();
                if (!lblNowServingNumber.Text.Contains(frontNumber))
                {
                    lblNowServingNumber.Text = frontNumber;
                }
            }
        }
    }
}