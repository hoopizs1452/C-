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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = (int)rowChoose.Value;
            string n = "";

            for(int i=1; i<=row; i++)
            {
                for (int j = 1; j <= i; j++)
                    n += "*";
                n += "\r\n";
            }

            MessageBox.Show(n);
        }
    }
}
