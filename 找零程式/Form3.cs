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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = ((int.Parse(textBox1.Text) * int.Parse(textBox2.Text)) +
                (int.Parse(textBox3.Text) * int.Parse(textBox4.Text))).ToString();
            textBox7.Text = (int.Parse(textBox5.Text) - int.Parse(textBox6.Text)).ToString();

            int fh, oh, ft, te, f, o;

            fh = int.Parse(textBox7.Text) / 500;
            oh = (int.Parse(textBox7.Text) % 500) / 100;
            ft = (int.Parse(textBox7.Text) % 500 % 100) / 50;
            te = (int.Parse(textBox7.Text) % 500 % 100 % 50) / 10;
            f = (int.Parse(textBox7.Text) % 500 % 100 % 50 % 10) / 5;
            o = (int.Parse(textBox7.Text) % 500 % 100 % 50 % 10 % 5) / 1;

            textBox8.Text = fh.ToString();
            textBox9.Text = oh.ToString();
            textBox10.Text = ft.ToString();
            textBox11.Text = te.ToString();
            textBox12.Text = f.ToString();
            textBox13.Text = o.ToString();
        }
    }
}
