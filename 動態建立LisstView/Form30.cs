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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String picPath;
            Image img;

            picPath = Application.ExecutablePath;
            for (int i = 0; i < 4; i++)
                picPath = System.IO.Directory.GetParent(picPath).ToString();
            picPath += "\\picture\\";

            img = Image.FromFile(picPath + "icon3.png");
            imageList1.Images.Add(img);
            img = Image.FromFile(picPath + "icon4.png");
            imageList1.Images.Add(img);
            listView1.SmallImageList = imageList1;

            img = Image.FromFile(picPath + "icon7.png");
            imageList2.Images.Add(img);
            img = Image.FromFile(picPath + "icon8.png");
            imageList2.Images.Add(img);
            listView1.StateImageList = imageList2;

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("狀態", 100);
            listView1.Columns.Add("姓名", 120);
            listView1.Columns.Add("住址", 150);
            listView1.Columns.Add("電話", 100);

            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] name = { "張三郎", "陳美麗", "王曉明" };
            string[] address = { "民生路225號", "愛國路1號", "中央路120號" };
            string[] phone = { "22576267", "22661878", "0938123456" };

            for(int i=0; i<3; i++)
            {
                listView1.Items[i].SubItems.Add(name[i]);
                listView1.Items[i].SubItems.Add(address[i]);
                listView1.Items[i].SubItems.Add(phone[i]);
                listView1.Items[i].StateImageIndex = 0;

                listView1.Items[0].ImageIndex = 0;
                listView1.Items[1].ImageIndex = 1;
                listView1.Items[2].ImageIndex = 0;

                button3.Enabled = false;
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            textBox1.Clear();

            foreach(ListViewItem item in listView1.CheckedItems)
            {
                foreach (ListViewItem.ListViewSubItem str in item.SubItems)
                    textBox1.AppendText(str.Text.ToString() + " ");
                textBox1.AppendText("\r\n");
            }
        }
    }
}
