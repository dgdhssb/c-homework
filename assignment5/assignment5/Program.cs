using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment5
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
        public List<Goods> Goods=new List<Goods>();

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
                details += $"货物的名称是{Goods[i].GoodName} 价格是{Goods[i].GoodPriced}\n";
                sumPrice += Goods[i].GoodPriced;
            }
            details += $"货物的总价是{sumPrice}\n";
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
            return $"订单序号为{orderID} 订单客户为{orderCustom}\n{orderDetails}";
        }
    }

    public class OrderService
    {
        public List<Order> Orders=new List<Order>();

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
            else { Orders.Add(order); }
        }
        //删除订单
        public void DeleteOrder(Order order)
        {
            if (!Orders.Contains(order))
            {
                throw new ArgumentException("订单不存在");
            }
            else { Orders.Remove(order); }
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
                int index = Orders.IndexOf(oldOrder);
                Orders[index] = newOrder;
            }
        }
        //查找订单——订单号
        public IEnumerable<Order> FindByOrderID(long orderID)
        {
            return Orders.Where(o => o.OrderID == orderID)
                .OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced));
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
            return Orders.Where(o => o.OrderCustom == customName)
                .OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced));
        }
        //查找订单——订单总金额
        public IEnumerable<Order> FindByPrice()
        {
            return Orders.OrderBy(o => o.orderDetails.Goods.Sum(g => g.GoodPriced));
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
            Goods good1 = new Goods("铅笔", 10.0);
            Goods good2 = new Goods("水彩笔", 15.5);
            Goods good3 = new Goods("蜡笔", 23.5);
            Goods good4 = new Goods("圆珠笔", 5.5);
            OrderDetails orderDetails1 = new OrderDetails(good1,good2);
            //创建重复订单明细
            OrderDetails orderDetails11=new OrderDetails(good1,good2);
            Console.WriteLine("orderDetails1和orderDetails11是否相同：" + orderDetails1.Equals(orderDetails11));
            Console.WriteLine("——————————————"); ;
            OrderDetails orderDetails2 = new OrderDetails(good2,good3);
            OrderDetails orderDetails3 = new OrderDetails(good1,good3);
            OrderDetails orderDetails4 = new OrderDetails(good1,good2,good4);   
            Order order1 = new Order(1, "李华", orderDetails1);
            //创建重复订单
            Order order11= new Order(1, "李华", orderDetails1);
            Console.WriteLine("order1和order11是否相同：" + order1.Equals(order11));
            Console.WriteLine("——————————————");
            Order order2 =new Order(2,"张三",orderDetails2);
            Order order3 = new Order(3, "王卫", orderDetails3);
            Order order4 = new Order(4, "王卫", orderDetails4);
            OrderService orderService=new OrderService();
            //增加订单
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.AddOrder(order4);
            foreach(Order order in orderService.Orders)
            {
                Console.WriteLine(order);
            }
            //查找订单——订单号
            Console.WriteLine("查找订单——订单号——1");
            Console.WriteLine("——————————————");
            IEnumerable<Order> O1=orderService.FindByOrderID(1);
            foreach(Order order in O1) { Console.WriteLine(order); }
            //查找订单——商品名称
            Console.WriteLine("查找订单——商品名称——水彩笔");
            Console.WriteLine("——————————————");
            IEnumerable<Order> S1 = orderService.FindByGoodName("水彩笔");
            foreach( Order order in S1) { Console.WriteLine(order); }
            //查找订单——客户
            Console.WriteLine("查找订单——客户——王卫");
            Console.WriteLine("——————————————");
            IEnumerable<Order> W1 = orderService.FindByCustom("王卫");
            foreach(Order order in W1) { Console.WriteLine(order);}
            //查找订单——订单总金额
            Console.WriteLine("查找订单——订单总金额");
            Console.WriteLine("——————————————");
            IEnumerable<Order> Q1 = orderService.FindByPrice();
            foreach(Order order in Q1) { Console.WriteLine(order); }
            //修改订单
            Console.WriteLine("修改订单——张三改为张山——ID2改为6");
            Console.WriteLine("——————————————");
            Order newOrder2 = new Order(6, "张山", orderDetails2);
            orderService.ChangeOrder(order2, newOrder2);
            //删除订单
            Console.WriteLine("删除订单——4");
            Console.WriteLine("——————————————");
            orderService.DeleteOrder(order4);
            //最终总订单
            Console.WriteLine("最终总订单——使用ID排序");
            Console.WriteLine("——————————————");
            orderService.SortOrders();
            foreach (Order order in orderService.Orders)
            {
                Console.WriteLine(order);
            }

        }
    }
    }

