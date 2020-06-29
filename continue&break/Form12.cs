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
    public partial class Form12 : Form
    {
        bool fg = true;
        public Form12()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            fg = true;
            textBox1.Focus();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            fg = false;
            textBox2.Focus();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            fg = true;
            radioButton1.Checked = true;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            fg = false;
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0, val;
            string str;

            textBox3.Clear();

            for(int i=1; i<=10; i++)
            {
                if(fg == true)
                {
                    val = Convert.ToInt32(textBox1.Text);
                    if (i == val)
                        continue;
                }
                else
                {
                    val = Convert.ToInt32(textBox2.Text);
                    if (i == val)
                        break;
                }
                sum += i;
                str = "i=" + i.ToString() + ",sum=" + sum.ToString() + "\r\n";
                textBox3.AppendText(str);
            }
        }
    }
}
