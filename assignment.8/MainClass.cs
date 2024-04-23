using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using Microsoft.Graph.Models;
using OrderApp.Models;

namespace OrderApp {

    class MainClass
    {
        //public static void Main()
        //{
        //    try
        //    {
        //        //OrderItem apple = new OrderItem(1, "apple",10.0, 80);
        //        //OrderItem egg = new OrderItem(2, "eggs",1.2, 200);
        //        //OrderItem milk = new OrderItem(3, "milk",50, 10);

        //        //Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
        //        //Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
        //        //Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });

        //        //OrderService os = new OrderService();


        //        //os.AddOrder(order1);
        //        //os.AddOrder(order2);
        //        //os.AddOrder(order3);
        //        //os.Export(@"./orders.xml");

        //        //Console.WriteLine("GetAllOrders");
        //        //List<Order> orders = os.Orders;

        //        //orders.ForEach(o => Console.WriteLine(o));
        //        //Console.WriteLine("");

        //        //os.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));
        //        //Console.WriteLine("GetAllOrders After sort");
        //        //orders = os.Orders;
        //        //orders.ForEach(o => Console.WriteLine(o));
        //        //Console.WriteLine("");

        //        //Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
        //        //orders = os.QueryOrdersByCustomerName("Customer2");
        //        //orders.ForEach(o => Console.WriteLine(o));
        //        //Console.WriteLine("");

        //        //Console.WriteLine("GetOrdersByGoodsName:'apple'");
        //        //orders = os.QueryOrdersByGoodsName("apple");
        //        //orders.ForEach(o => Console.WriteLine(o));
        //        //Console.WriteLine("");

        //        //Console.WriteLine("Remove order(id=2) and qurey all");
        //        //os.RemoveOrder(2);
        //        //orders.ForEach(o => Console.WriteLine(o));
        //        //Console.WriteLine("");

        //        //Console.WriteLine("Import from ./orders.xml");
        //        //OrderService os2 = new OrderService();
        //        //os2.Import("./orders.xml");
        //        //os2.Orders.ForEach(order => Console.WriteLine(order));


        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine(e.StackTrace);
        //    }


        //}
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //把DbContext加入到容器
            builder.Services.AddDbContext<OrdersContext>(opt => opt.UseMySQL(
                "Server=localhost;Database=OrdersDB;User=root;Password=chen123"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseDefaultFiles(); //启用缺省静态页面（index.html或index.htm）
            app.UseStaticFiles(); //启用静态文件（页面、js、图片等各种前端文件）

            // 手动指定HTTPS端口

            app.UseHttpsRedirection(); //启动http到https的重定向
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }

    }

}

