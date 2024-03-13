using System;

namespace work3_1
{
    public interface Shape
    {
        double Area();
        bool IsLegal();
    }

    public class Rectangle : Shape
    {
        public double length;
        public double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area()
        {
            return length * width;
        }

        public bool IsLegal()
        {
            return length > 0 && width > 0;
        }
        
    }

    public class Square : Shape
    {
        public double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double Area() { return side * side; }

        public bool IsLegal() { return side > 0; }
    }

    public class Triangle : Shape
    {
        public double firstEdge;
        public double secondEdge;
        public double thirdEdge;

        public Triangle(double firstEdge, double secondEdge, double thirdEdge)
        {
            this.firstEdge = firstEdge;
            this.secondEdge = secondEdge;
            this.thirdEdge = thirdEdge;
        }

        public double Area() 
        { 
            double p=(firstEdge+secondEdge+thirdEdge)/2;
            double ss=p*(p-firstEdge)*(p-secondEdge)*(p-thirdEdge);
            double s=Math.Sqrt(ss);
            return s;
        }
        public bool IsLegal() 
        {
            return firstEdge>0&&secondEdge>0&&thirdEdge>0&&((firstEdge+secondEdge>thirdEdge)||(firstEdge+thirdEdge>secondEdge)
                ||(secondEdge+thirdEdge>firstEdge));
        }
    }

    public class ExpressThem
    {
        public void ToString(Shape shape)
        {
            Console.WriteLine("图形是否合理：" + shape.IsLegal());
            if(!shape.IsLegal()) { throw new Exception("图形不合理！！！"); }
            Console.WriteLine("图形的面积为：" + shape.Area());

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ExpressThem expressThem = new ExpressThem();
            try
            {
                Rectangle rectangle = new Rectangle(4.0, 5.0);
                Console.WriteLine("矩形：");
                expressThem.ToString(rectangle);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                Square square = new Square(-1.0);
                Console.WriteLine("正方形：");
                expressThem.ToString(square);
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                Triangle triangle = new Triangle(3.0, 4.0, 5.0);
                Console.WriteLine("三角形：");
                expressThem.ToString(triangle);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
