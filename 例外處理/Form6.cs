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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = 1, b = 1, c;
            bool fgError;

            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                fgError = false;
            }
            catch(FormatException ex)
            {
                textBox3.AppendText(ex.Message + "\r\n");
                a = 1;
                b = 1;
                fgError = true;
            }
            finally
            {
                textBox3.AppendText("a = " + a.ToString() + "\r\n");
                textBox3.AppendText("b = " + b.ToString() + "\r\n");
            }

            if(fgError == false)
                try
                {
                    c = a / b;
                    label3.Text = c.ToString();
                }
                catch(DivideByZeroException ex)
                {
                    textBox3.AppendText(ex.Message + "\r\n");
                    label3.Text = "";
                    b = 1;
                    textBox2.Text = b.ToString();
                }
        }
    }
}
