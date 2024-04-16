using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = '*';
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text =="chen"&&this.textBox2.Text=="520")
            {
                MessageBox.Show("登陆成功");
                OrderSystem orderSystem = new OrderSystem();
                this.Hide();
                orderSystem.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("请重试");
            }
        }
    }
}
