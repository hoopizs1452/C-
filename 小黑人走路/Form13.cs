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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10, move = 10, index = 0;
            pictureBox1.Left = x;
            pictureBox1.Width = imageList1.ImageSize.Width;
            pictureBox1.Height = imageList1.ImageSize.Height;

            while(x + pictureBox1.Width + move < ClientSize.Width)
            {
                pictureBox1.Image = imageList1.Images[index];
                x += move;
                pictureBox1.Left = x;

                if (++index > 4)
                    index = 0;

                Refresh();
                System.Threading.Thread.Sleep(100);

                Application.DoEvents();
            }
        }
    }
}
