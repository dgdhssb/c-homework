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
    public partial class OrderSystem : Form
    {
        public OrderSystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderHHH addOrderHHH = new AddOrderHHH();
            this.Hide();
            addOrderHHH.ShowDialog();
            this.Show();
        }

        private void OrderSystem_Load(object sender, EventArgs e)
        {

        }

        private void GoodsButton_Click(object sender, EventArgs e)
        {
            AllGoods goods = new AllGoods();
            this.Hide();
            goods.ShowDialog();
            this.Show();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindOrders findOrders = new FindOrders();
            this.Hide();    
            findOrders.ShowDialog();
            this.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder();
            this.Hide();    
            deleteOrder.ShowDialog();
            this.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeOrder changeOrder = new ChangeOrder();
            this.Hide();
            changeOrder.ShowDialog();
            this.Show();
        }
    }
}
