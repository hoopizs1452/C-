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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text), en = Convert.ToInt32(textBox2.Text)
                , m = Convert.ToInt32(textBox3.Text);
            double avg = (c + en + m) / 3;
            if (avg >= 85 && c >= 80 && en >= 80 && m >= 80)
                label4.Text = "符合資格";
            else
                label4.Text = "不符合資格";
        }
    }
}
