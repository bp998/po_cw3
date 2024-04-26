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
        string value1;
        string value2;
        string beetwen;

        private void error(string text)
        {
            if(text != null)
            {
                textBoxOutput.Text = text;
            } else
            {
                textBoxOutput.Text = "Nieprawidłowe dane";
            }
            beetwen = null;
            value1 = null;
            value2 = null;
        }


        private void calc(double valueA, double valueB, string beetwen)
        {
            double result;

            if(beetwen == "+")
            {
                result = Math.Round((valueA + valueB)* 100) / 100;
                textBoxOutput.Text = (result).ToString();
                value1 = result.ToString();

            }
            else if(beetwen == "-")
            {
                result = Math.Round((valueA - valueB) * 100) / 100;
                textBoxOutput.Text = (result).ToString();
                value1 = result.ToString();
            }
            else if(beetwen == "*")
            {
                result = Math.Round((valueA * valueB) * 100) / 100;  
                textBoxOutput.Text = (result).ToString();
                value1 = result.ToString();
            }
            else if(beetwen == "/")
            {
                if (valueB == 0)
                {
                    error("Nie dziel przez 0");
                }
                else
                {
                    result = Math.Round((valueA / valueB) * 100) / 100;
                    textBoxOutput.Text = (result).ToString();
                    value1 = result.ToString();
                }
            }
            value2 = null;
            beetwen = null;
        }

        private bool tryAdd(string value)
        {
            if (beetwen != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void addValue(string value)
        {
            if(textBoxOutput.Text == "Nieprawidłowe dane" || textBoxOutput.Text == "Nie dziel przez 0" || textBoxOutput.Text == "Zacznij od cyfry")
            {
                textBoxOutput.Text = "";
            }
            if (beetwen != null)
            {
                value2 += value;
                textBoxOutput.Text = textBoxOutput.Text + value;
            }
            else
            {
                value1 += value;
                textBoxOutput.Text = textBoxOutput.Text + value;
            }
        }

        private void operation(string value)
        {
            if (tryAdd(value))
            {
                calc(double.Parse(value1), double.Parse(value2), beetwen);
            }
            if (value1 == null && value2 == null)
            { 
                error("Zacznij od cyfry");
            }
            else if (value == "+")
            {

                beetwen = "+";
                textBoxOutput.Text = textBoxOutput.Text + value;
            }
            else if(value == "-")
            {
                beetwen = "-";
                textBoxOutput.Text = textBoxOutput.Text + value;
            }
            else if(value == "*")
            {
                beetwen = "*";
                textBoxOutput.Text = textBoxOutput.Text + value;
            }
            else if(value == "/")
            {
                beetwen = "/";
                textBoxOutput.Text = textBoxOutput.Text + value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addValue(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addValue(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addValue(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addValue(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addValue(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addValue(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addValue(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addValue(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addValue(button9.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addValue(button14.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operation(button10.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
           operation(button11.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation(button12.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation(button13.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(value1 != null && value2 != null && beetwen != null)
            {
                calc(double.Parse(value1), double.Parse(value2), beetwen);
                beetwen = null;
                value2 = null;

            } else
            {
               error(null);
            }
           
        }
        

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            value1 = null;
            value2 = null;
            beetwen = null;
            textBoxOutput.Text = "";
        }

       
    }
}
