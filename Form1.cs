using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace po_cw3
{
    public partial class Form1 : Form
    {
        List<string> values = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "1";
            values.Add("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "2";
            values.Add("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "3";
            values.Add("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "4";
            values.Add("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "5";
            values.Add("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "6";
            values.Add("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "7";
            values.Add("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "8";
            values.Add("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "9";
            values.Add("9");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "0";
            values.Add("0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "+";
            values.Add("+");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "-";
            values.Add("-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "*";
            values.Add("*");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "/";
            values.Add("/");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double result = 0;
            double currentNumber = 0;
            char operation = '+';

            foreach (string value in values)
            {
                if (double.TryParse(value, out double number))
                {
                    switch (operation)
                    {
                        case '+':
                            result += currentNumber;
                            currentNumber = number;
                            break;
                        case '-':
                            result += currentNumber;
                            currentNumber = -number;
                            break;
                        case '*':
                            currentNumber *= number;
                            break;
                        case '/':
                            if (number != 0)
                            {
                                currentNumber /= number;
                            }
                            else
                            {
                                textBoxOutput.Text = "Error: Division by zero";
                                return;
                            }
                            break;
                    }
                }
                else if (value.Length == 1)
                {
                    operation = value[0];
                }
            }

            result += currentNumber;
            textBoxOutput.Text = result.ToString();
            values.Clear();
        }
    }
}
