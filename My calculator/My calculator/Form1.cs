using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_calculator
{
    public partial class Form1 : Form
    {
        double c, d;
        string m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            m = button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            m = button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            m = button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            m = button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            d = Convert.ToDouble(textBox1.Text);
            switch (m)
            {
                case ("+"):
                    textBox1.Text = Convert.ToString(c + d);
                    break;
                case ("-"):
                    textBox1.Text = Convert.ToString(c - d);
                    break;
                case ("*"):
                    textBox1.Text = Convert.ToString(c * d);
                    break;
                case ("/"):
                    textBox1.Text = Convert.ToString(c / d);
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
