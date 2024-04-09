using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class FindOrders : Form
    {
        public OrderService orderService = new OrderService();
        public FindOrders()
        {
            InitializeComponent();
            foreach (Order order in AddOrderHHH.Orders)
            {
               orderService.AddOrder(order);
            }
        }
        
        //ID Button
        private void FindIDButton_Click(object sender, EventArgs e)
        {
            long id = long.Parse(IDTextBox.Text);
            IEnumerable<Order> OID = orderService.FindByOrderID(id);
            string result = "";
            foreach (Order order in OID) { result += order; }
            ResultLabel.Text=result;
            NameTextBox.Clear();
            CustomNameTextBox.Clear();
        }

        //Name Button
        private void OrderNameButton_Click(object sender, EventArgs e)
        {
            string name=NameTextBox.Text;
            IEnumerable<Order> OName = orderService.FindByGoodName(name);
            string result = "";
            foreach (Order order in OName) { result += order; }
            ResultLabel.Text = result;
            IDTextBox.Clear();
            CustomNameTextBox.Clear();
        }

        private void CustomNameButton_Click(object sender, EventArgs e)
        {
            string name = CustomNameTextBox.Text;
            IEnumerable<Order> OCustomName = orderService.FindByCustom(name);
            string result = "";
            foreach (Order order in OCustomName) { result += order; }
            ResultLabel.Text = result;
            NameTextBox.Clear();
            IDTextBox.Clear();
        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            string result = "";
            IEnumerable<Order> OPrice = orderService.FindByPrice();
            foreach (Order order in OPrice) { result += order; }
            ResultLabel.Text = result;
            NameTextBox.Clear();
            IDTextBox.Clear();
            CustomNameTextBox.Clear();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            orderService.SortOrders();
            string result = "";
            foreach (Order order in orderService.Orders)
            {
                result += order;
            }
            ResultLabel.Text = result;
            NameTextBox.Clear();
            IDTextBox.Clear();
            CustomNameTextBox.Clear();
        }
    }
}
