using System;
using System.Windows.Forms;

namespace Delegate_String
{
    public delegate X DisplayOutput<X>(X arg);

    class GenericDelegates
    {
        public static string getMessage(string msg)
        {
            return msg;
        }
    }

    public partial class FormMessage : Form
    {
        DisplayOutput<string> displayStringValue;

        public FormMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayStringValue = new DisplayOutput<string>(GenericDelegates.getMessage);
            MessageBox.Show(displayStringValue(txtBoxMsg.Text));
        }
    }
}