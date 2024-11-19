using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreet_Click(object sender, EventArgs e)
        {
            // Check if the TextBox is not empty
            if (!string.IsNullOrWhiteSpace(textBoxname.Text))
            {
                // Update the label with a personalized greeting message
                labelMessage.Text = $"Hello, {textBoxname.Text}! Welcome!";
            }
            else
            {
                // Prompt the user to enter their name
                labelMessage.Text = "Please enter your name.";
            }
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
