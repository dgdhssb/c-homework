using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment6
{
    public partial class ChangeOrder : Form
    {
        public ChangeOrder()
        {
            InitializeComponent();
        }

        //前ID号
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LookLabel_Click(object sender, EventArgs e)
        {
            int nums = 0;
            foreach (Goods good in AllGoods.allGoods)
            {
                GoodsListBox.Items.Add($"商品序号{nums} " + good.ToString());
                nums++;
            }
            LookLabel.Enabled = false;
        }

        //修改订单按钮
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            long id = long.Parse(OldIDTextBox.Text);

            Order orderToModify = FindOrders.orderService.Orders.FirstOrDefault(o => o.OrderID == id);

            if (orderToModify != null)
            {
                if (!string.IsNullOrEmpty(NewNameTextBox.Text))
                {
                    orderToModify.OrderCustom = NewNameTextBox.Text;
                }

                if (!string.IsNullOrEmpty(NewIDTextBox.Text))
                {
                    long newOrderID=long.Parse(NewIDTextBox.Text);
                    if (FindOrders.orderService.Orders.Any(o => o.OrderID == newOrderID))
                    {
                        MessageBox.Show("新订单号与已存在订单号相同，请输入不同的订单号。");
                    }
                    else
                    {
                        orderToModify.OrderID = newOrderID;
                    }
                }

                // 修改订单商品信息
                orderToModify.orderDetails.Goods.Clear();
                foreach (int index in GoodsListBox.SelectedIndices)
                {
                    orderToModify.orderDetails.Goods.Add(AllGoods.allGoods[index]);
                }
            }
            else
            {
                MessageBox.Show("未找到指定ID的订单");
            }
            OldIDTextBox.Clear();
            NewIDTextBox.Clear();   
            NewNameTextBox.Clear();
            for (int i = 0; i < GoodsListBox.Items.Count; i++)
            {
                GoodsListBox.SetSelected(i, false); // 取消 ListBox 中所有项目的选中状态
            }
        }

        //新ID号
        private void NewIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //新订单用户姓名
        private void NewNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //新选择商品
        private void GoodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
