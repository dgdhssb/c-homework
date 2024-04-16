using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace assignment6
{
    public class Goods
    {
        private string goodName;
        private double goodPriced;

        public string GoodName { get { return goodName; } set { goodName = value; } }
        public double GoodPriced { get { return goodPriced; } set { goodPriced = value; } }

        public Goods(string GoodName, double GoodPriced)
        {
            this.GoodName = GoodName;
            this.GoodPriced = GoodPriced;
        }

        public override string ToString()
        {
            return $"货物的名称是{GoodName} 货物的价格是{GoodPriced}";
        }
    }

    public class OrderDetails
    {
        public List<Goods> Goods = new List<Goods>();

        public OrderDetails(params Goods[] goods)
        {
            Goods.AddRange(goods);
        }

        public override bool Equals(object obj)
        {
            OrderDetails other = obj as OrderDetails;

            return other != null && other.Goods.SequenceEqual(this.Goods);
        }

        public override string ToString()
        {
            double sumPrice = 0;
            string details = null;
            for (int i = 0; i < this.Goods.Count; i++)
            {
                details += $" 货物的名称是{Goods[i].GoodName} 价格是{Goods[i].GoodPriced}\n";
                sumPrice += Goods[i].GoodPriced;
            }
            details += $" 货物的总价是{sumPrice}\n";
            return details;
        }
    }
    public class Order
    {
        private long orderID;
        private string orderCustom;

        public OrderDetails orderDetails;
        public long OrderID { get => orderID; set => orderID = value; }
        public string OrderCustom { get => orderCustom; set => orderCustom = value; }

        public Order(long OrderID, string OrderCustom, OrderDetails orderDetails)
        {
            this.OrderID = OrderID;
            this.OrderCustom = OrderCustom;
            this.orderDetails = orderDetails;
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;

            return order != null && order.OrderID == this.OrderID
                && order.OrderCustom == this.OrderCustom && order.orderDetails == this.orderDetails;
        }

        public override string ToString()
        {
            return $"订单序号为{orderID} 订单客户为{orderCustom} \n{orderDetails}";
        }
    }

    public class OrderService
    {
        public List<Order> Orders = new List<Order>();

        // 连接到 MySQL 数据库的连接字符串
        private string connectionString = "server=localhost;database=orders;uid=root;password=chen123;";

        // 对订单进行排序
        public void SortOrders()
        {
            // 默认按照订单号排序
            Orders = Orders.OrderBy(o => o.OrderID).ToList();
        }

        //增加订单
        public void AddOrder(Order order)
        {
            if (Orders.Contains(order))
            {
                throw new ArgumentException("订单重复添加");
            }
            else 
            {
                ////
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO orders (order_id, order_custom) VALUES (@OrderID, @OrderCustom)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderID", order.OrderID);
                    command.Parameters.AddWithValue("@OrderCustom", order.OrderCustom);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                Orders.Add(order); 
            }
        }
        //删除订单
        public void DeleteOrder(Order order)
        {
            if (!Orders.Contains(order))
            {
                throw new ArgumentException("订单不存在");
            }
            else 
            {
                ///
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM orders WHERE order_id = @OrderID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderID", order.OrderID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                Orders.Remove(order); 
            }
        }
        //修改订单
        public void ChangeOrder(Order oldOrder, Order newOrder)
        {
            if (!Orders.Contains(oldOrder))
            {
                throw new ArgumentException("要修改的订单不存在");
            }
            else
            {
                ///
                using(MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE orders SET order_id = @NewOrderID, order_custom = @OrderCustom WHERE order_id = @OldOrderID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NewOrderID", newOrder.OrderID);
                    command.Parameters.AddWithValue("@OrderCustom", newOrder.OrderCustom);
                    command.Parameters.AddWithValue("@OldOrderID", oldOrder.OrderID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                int index = Orders.IndexOf(oldOrder);
                Orders[index] = newOrder;
            }
        }
        //查找订单——订单号
        public IEnumerable<Order> FindByOrderID(long orderID)
        {
            //return Orders.Where(o => o.OrderID == orderID)
            //    .OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced));
            List<Order> foundOrders = new List<Order>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM orders WHERE order_id = @OrderID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderID);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long orderId = Convert.ToInt64(reader["order_id"]);
                        string orderCustom = reader["order_custom"].ToString();
                        foundOrders= Orders.Where(o => o.OrderID == orderId ).OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced)).ToList();
                    }
                }
            }
            return foundOrders;
        }
        //查找订单——商品名称
        public IEnumerable<Order> FindByGoodName(string goodName)
        {
            return Orders.Where(o => o.orderDetails.Goods.Any(g => g.GoodName == goodName))
                .OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced));

        }
        //查找订单——客户
        public IEnumerable<Order> FindByCustom(string customName)
        {
            //return Orders.Where(o => o.OrderCustom == customName)
            //    .OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced));
            List<Order> foundOrders = new List<Order>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM orders WHERE order_custom = @CustomName";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomName", customName);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long orderID = Convert.ToInt64(reader["order_id"]);
                        string orderCustom = reader["order_custom"].ToString();
                     
                        foundOrders= Orders.Where(o => o.OrderCustom == orderCustom)
                .OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced)).ToList();
                    }
                }
            }

            return foundOrders;
        }
        //查找订单——订单总金额
        public IEnumerable<Order> FindByPrice()
        {
            return Orders.OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced));

        }
    }
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
