using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        int num1, num2;
        string str = "";

        private void button13_Click(object sender, EventArgs e)
        {
            jisuan();
            str = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            jisuan();
            str = "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            jisuan();
            str = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            jisuan();
            str = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            jisuan();
            str = "%";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);
            textBox1.Text = "";

            if (str == "+")
                textBox1.Text = (num1 + num2).ToString();
            if (str == "-")
                textBox1.Text = (num1 - num2).ToString();
            if (str == "*")
                textBox1.Text = (num1 * num2).ToString();
            if (str == "/")
                textBox1.Text = (num1 / num2).ToString();
            if (str == "%")
                textBox1.Text = (num1 % num2).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            str = "";
        }

        private void jisuan()
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
