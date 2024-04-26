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


        private void calc(int value1, int value2, string beetwen)
        {

            if(beetwen == "+")
            {
                textBoxOutput.Text = (value1 + value2).ToString();           
            }
            else if(beetwen == "-")
            {
                textBoxOutput.Text = (value1 - value2).ToString();
            }
            else if(beetwen == "*")
            {
                textBoxOutput.Text = (value1 * value2).ToString();
            }
            else if(beetwen == "/")
            {
                textBoxOutput.Text = (value1 / value2).ToString();
            }
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
                calc(int.Parse(value1), int.Parse(value2), beetwen);
            }
            if (value == "+")
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
            calc(int.Parse(value1), int.Parse(value2), beetwen);
            value1 = null;
            value2 = null;
            beetwen = null;
        }
        

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
