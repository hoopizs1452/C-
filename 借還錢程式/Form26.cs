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
    public partial class Form26 : Form
    {
        Person i, friend;

        public Form26()
        {
            InitializeComponent();
        }

        private void borrowBottom_Click(object sender, EventArgs e)
        {
            i.borrow(friend, 100000);
            if (friend.money <= 0)
                MessageBox.Show(friend.name + "的錢不夠借!!");
            myMoneyLabel.Text = i.money.ToString();
            friendMoneyLabel.Text = friend.money.ToString();
        }

        private void repayBottom_Click(object sender, EventArgs e)
        {
            i.repay(friend, 100000);
            if (i.money <= 0)
                MessageBox.Show(i.name + "的錢不夠還!!");
            myMoneyLabel.Text = i.money.ToString();
            friendMoneyLabel.Text = friend.money.ToString();
        }

        private void checkBottom_Click(object sender, EventArgs e)
        {
            i = new Person(myNameInput.Text, 0);
            friend = new Person(friendNameInput.Text, 200000);
            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            checkBottom.Enabled = false;
            borrowBottom.Text = "跟" + friend.name +"借1000$";
            repayBottom.Text = "還給" + friend.name + "1000$";
            borrowBottom.Enabled = true;
            repayBottom.Enabled = true;

            myNameLabel.Text = i.name;
            friendNameLabel.Text = friend.name;
        }
    }
}
