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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string species = comboBox1.SelectedItem.ToString();
            int count;

            try
            {
                count = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            switch (species)
            {
                case "全票(60元)":
                    label4.Text = Convert.ToString(count * 60);
                    break;
                case "優待票(30元)":
                    label4.Text = Convert.ToString(count * 30);
                    break;
                case "免費票":
                    label4.Text = "0";
                    break;
                case "團體票(七折)":
                    if (count < 30)
                        MessageBox.Show("人數不符合團體票原則");
                    else
                        label4.Text = Convert.ToString(count * 60 * 0.7);
                    break;
            }
        }
    }
}
