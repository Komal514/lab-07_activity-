using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adding items to the ComboBox
            comboBoxSize.Items.Add("Small");
            comboBoxSize.Items.Add("Medium");
            comboBoxSize.Items.Add("Large");
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            StringBuilder toppings = new StringBuilder("Toppings: ");
            if (checkBoxCheese.Checked) toppings.Append("Cheese, ");
            if (checkBoxPepperoni.Checked) toppings.Append("Pepperoni, ");
            if (checkBoxMushrooms.Checked) toppings.Append("Mushrooms, ");
            if (toppings.ToString() == "Toppings: ") toppings.Append("None");

            // Gather selected crust type
            string crustType = radioButtonThinCrust.Checked ? "Thin Crust" :
                               radioButtonThickCrust.Checked ? "Thick Crust" :
                               "Not selected";

            // Create the order summary
            string orderSummary = $"Pizza Size: {comboBoxSize}\n{toppings.ToString().TrimEnd(',', ' ')}\nCrust Type: {crustType}";

            // Display the order summary in the label
            label1.Text = orderSummary;
        }
    }
}
      
