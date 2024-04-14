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
        List<int> values = new List<int>();
        List<string> operators = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 1;
            values.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 2;
            values.Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 3;
            values.Add(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 4;
            values.Add(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 5;
            values.Add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 6;
            values.Add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 7;
            values.Add(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 8;
            values.Add(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 9;
            values.Add(9);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + 0;
            values.Add(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "+";
            operators.Add(textBoxOutput.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "-";
            operators.Add(textBoxOutput.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "*";
            operators.Add(textBoxOutput.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + "/";
            operators.Add(textBoxOutput.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }
    }
}
