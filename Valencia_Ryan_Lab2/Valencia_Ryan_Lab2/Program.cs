using System;
using System.Windows.Forms;

namespace Valencia_Ryan_Lab2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CashierWindowQueueForm cashierForm = new CashierWindowQueueForm();
            cashierForm.StartPosition = FormStartPosition.Manual;
            cashierForm.Location = new System.Drawing.Point(200, 150);
            cashierForm.Show();

            QueuingForm queuingForm = new QueuingForm();
            queuingForm.StartPosition = FormStartPosition.Manual;
            queuingForm.Location = new System.Drawing.Point(600, 150);
            queuingForm.Show();

            CustomerView customerView = new CustomerView();
            customerView.StartPosition = FormStartPosition.Manual;
            customerView.Location = new System.Drawing.Point(1000, 150);
            customerView.Show();

            Application.Run(queuingForm);
        }
    }
}