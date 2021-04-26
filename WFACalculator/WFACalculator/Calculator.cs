using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACalculator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

      


        private void btnNum_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (operation_pressed))
                txtDisplay.Clear();
            Button b = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + b.Text;
            operation_pressed = true;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtDisplay.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

     

        private void btnEqual_Click(object sender, EventArgs e)
        {
           operation_pressed = false;
            equation.Text = "";

            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (value + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (value - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (value * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (value / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text="0";
            value = 0;
        }

        
    }
}
 