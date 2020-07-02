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
    public partial class Form23 : Form
    {
        TextBox tb = null;
        Button btn = null;

        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb = new TextBox();
            tb.Location = new Point(25, button1.Location.Y + button1.Height + 10);
            tb.Text = "王小明";
            tb.Width = 150;
            this.Controls.Add(tb);

            btn = new Button();
            btn.Location = new Point(25, tb.Location.Y + tb.Height + 10);
            btn.Text = "Click me";
            btn.AutoSize = true;
            this.Controls.Add(btn);
            btn.Click += MyClick;

        }

        private void MyClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, 動態按鈕");
            this.Controls.Remove(tb);
        }
    }
}
