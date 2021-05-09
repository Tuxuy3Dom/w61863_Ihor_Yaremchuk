using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double firstNum, secondNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operationalFunctional(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }

            firstNum = Double.Parse(textBox1.Text);
            operation = b.Text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(textBox1.Text);

            switch(operation)
            {
                case "+":
                    textBox1.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(firstNum / secondNum);
                    break;
                default:
                    break;
            }
        }

        private void numericalVariable(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (textBox1.Text == "0")
                textBox1.Text = "";

            if (b.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + b.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + b.Text;
            }
        }
    }
}
