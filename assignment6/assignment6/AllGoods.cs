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
    public partial class AllGoods : Form
    {
        public static List<Goods> allGoods = new List<Goods>();
        public string OrderName { get; set; }
        public double Price { get; set; }
        public AllGoods()
        {
            InitializeComponent();
        }

        private void OneOrderButton_Click(object sender, EventArgs e)
        {
            OrderName = OrderNameTextBox.Text;
            Price = double.Parse(OrderPriceTextBox.Text);
            Goods good=new Goods(OrderName, Price);
            allGoods.Add(good);
            OrderNameTextBox.Clear();
            OrderPriceTextBox.Clear();
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteGoodsButton_Click(object sender, EventArgs e)
        {
            allGoods.Clear();
        }
    }
}
