using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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
        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (operation_pressed))
                txtDisplay.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + b.Text;
               
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtDisplay.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }
        private void operation_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch (operation)
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
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            double percentage = 0.01;

            double comission = value * percentage;

            txtDisplay.Text = comission.ToString();
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(".");
            btnDecimal.Enabled = true;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * q);
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            value = 0;
        }
    }
}