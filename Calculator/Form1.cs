////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
///name     date        description
///baint    1-22-19     calculator program created
///baint    1-24-19     layout for calc created
///baint    1-29-19     operators created
///baint    2-1-19      decimal functionality created

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            if (display.Text == "0") //|| (operationStarted == true))
            {
                display.Text = "";
            }
            //TODO: Can write as simplier statement  
            
            //Button btn = (Button)sender;
            //string buttonText = btn.Text;
            //display.Text = display.Text + buttonText;


            //Button btn = (Button)sender;
            //string buttonText = btn.Text;
            display.Text += ((Button)sender).Text;


        }

        private void positiveNegativeBtn_Click(object sender, EventArgs e)
        {
            double y = double.Parse(display.Text);
            y = -y;
            display.Text = y.ToString();
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        double memoryLoc = 0.0;     //save first operand of a math operation
        string operation = string.Empty;    //save the selected math operation
        bool operationStarted = false;

        private void operatorBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;   //get the operation from the button

            //save the operand value
            memoryLoc = double.Parse(display.Text);
            operationStarted = true;
            display.Clear();
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    display.Text = (memoryLoc + double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (memoryLoc - double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (memoryLoc * double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (memoryLoc / double.Parse(display.Text)).ToString();
                    break;
                default:
                    Console.WriteLine("ERROR: This code should be unreachable.");
                    break;
            }
            //done with current math operation
            operationStarted = false;
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            display.Text += ((Button)sender).Text;
        }
    }
}
