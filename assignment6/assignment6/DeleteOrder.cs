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
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void AllOrderLabel_Click(object sender, EventArgs e)
        {
            foreach(Order order in AddOrderHHH.Orders)
            {
                AllOrderlistBox.Items.Add(order);
            }
        }

        private void AllOrderlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseDeleteButton_Click(object sender, EventArgs e)
        {
            List<Order> ordersToDelete = new List<Order>();

            foreach (Order order in AllOrderlistBox.SelectedItems)
            {
                ordersToDelete.Add(order);
            }

            foreach (Order order in ordersToDelete)
            {
                AddOrderHHH.Orders.Remove(order);
                AllOrderlistBox.Items.Remove(order);
            }
        }
    }
}
