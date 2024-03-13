using System;

namespace work3_2
{
    public interface AnyShape
    {
        double Area();
    }

    public class Rectangle : AnyShape
    {
        public double Length { get; set; }
        public double Width {  get; set; }
       
        public double Area()
        {
            return Length * Width;
        }
    }

    public class Square : AnyShape
    {
        public double Side { set; get; }
        public double Area() { return Side * Side; }
    }

    public class Triangle : AnyShape
    {
        public double Tbase { set; get; }
        public double Height { set; get; }
        public double Area() { return Height*Tbase/2; }
    }

    public class FactorShape
    {
        readonly Random random = new Random();
        public double GetNumber()
        {
            return random.Next(5,20);
        }
        public AnyShape CreatShape(string shapeName)
        {
            switch(shapeName)
            {
                case "Rectangle":
                    return new Rectangle { Width = GetNumber(),Length=GetNumber() };
                case "Square":
                    return new Square { Side = GetNumber() };
                case "Triangle":
                    return new Triangle { Height = GetNumber(),Tbase=GetNumber() };
                default:
                    throw new NotImplementedException();
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            FactorShape factorShape = new FactorShape();
            double totalArea=0;
            string[] shapes = { "Rectangle", "Square", "Triangle" };
            Random random = new Random();
            for (int i = 0;i<10;i++)
            {
                int luckyNum=random.Next(3);
                AnyShape shape = factorShape.CreatShape(shapes[luckyNum]);
                Console.WriteLine($"第{i + 1}个形状是：{shapes[luckyNum]} 面积为：{shape.Area()}");
                totalArea += shape.Area();
            }
            Console.WriteLine("十个对象形状的面积和为： " + totalArea);
            Console.ReadKey();
        }
    }
}
