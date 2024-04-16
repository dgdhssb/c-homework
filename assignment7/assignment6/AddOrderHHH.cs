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
    public partial class AddOrderHHH : Form
    {
        //public static List<Order> Orders = new List<Order>();
        public AddOrderHHH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void OrderNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void OrderPriceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void OrderPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void OrderNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AllButton_Click(object sender, EventArgs e)
        {

        }

        private void NameIDButton_Click(object sender, EventArgs e)
        {
            List<Goods> selectedGoods = new List<Goods>();
            foreach (int index in GoodsListBox.SelectedIndices)
            {
                // 从 allGoods 列表中获取选中的商品
                selectedGoods.Add(AllGoods.allGoods[index]);
            }
            // 将选中的商品添加到订单详情中
            OrderDetails orderDetails = new OrderDetails(selectedGoods.ToArray());
            long OrderorderID=long.Parse(IDTextBox.Text);
            string orderCustom=NameTextBox.Text;
            Order order=new Order(OrderorderID, orderCustom,orderDetails);
            IDTextBox.Clear();
            NameTextBox.Clear();
            for (int i = 0; i < GoodsListBox.Items.Count; i++)
            {
                GoodsListBox.SetSelected(i, false); // 取消 ListBox 中所有项目的选中状态
            }
            FindOrders.orderService.Orders.Add(order);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            int nums = 0;
            foreach(Goods good in AllGoods.allGoods)
            {
                GoodsListBox.Items.Add($"商品序号{nums} " + good.ToString());
                nums++;
            }
            label1.Enabled=false;
        }

        private void GoodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
