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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = comboBox1.SelectedItem.ToString();
            switch (month)
            {
                case "三月":
                case "四月":
                case "五月": label3.Text = "春季";
                    break;
                case "六月":
                case "七月":
                case "八月": label3.Text = "夏季";
                    break;
                case "九月":
                case "十月":
                case "十一月": label3.Text = "秋季";
                    break;
                case "十二月":
                case "一月":
                case "二月": label3.Text = "冬季";
                    break;
            }
        }
    }
}
