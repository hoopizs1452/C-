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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();

            for(int i=0; i<=3; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 25;
            }
            dataGridView1.Rows[3].ReadOnly = true;

            for (int i = 0; i < 5; i++)
                dataGridView1.Columns[i].Width = 70;

            dataGridView1.Width = dataGridView1.Columns[0].Width * 7;
            dataGridView1.Height = dataGridView1.Rows[0].Height * 6;

            dataGridView1.Rows[0].Cells[0].Value = "CTM601";
            dataGridView1.Rows[1].Cells[0].Value = "CTM507";
            dataGridView1.Rows[2].Cells[0].Value = "CTM512";
            dataGridView1.Rows[3].Cells[0].Value = "平均";

            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.LightGray;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] rev = new int[3, 4];
            Single avg;

            try
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 4; j++)
                        rev[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("輸入有誤");
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                avg = 0.0f;
                for (int j = 0; j < 4; j++)
                    avg += rev[i, j];
                avg /= 4.0f;
                dataGridView1.Rows[i].Cells[5].Value = avg.ToString();
            }

            for(int i=0; i<4; i++)
            {
                avg = 0.0f;
                for (int j = 0; j < 3; j++)
                    avg += rev[j, i];
                avg /= 3.0f;
                dataGridView1.Rows[3].Cells[i + 1].Value = avg.ToString();
            }
        }
    }
}
