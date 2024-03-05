using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字:");
            string number1 = Console.ReadLine();
            int numberOne = Int32.Parse(number1);
            Console.WriteLine("请输入运算符:");
            string sign = Console.ReadLine();
            Console.WriteLine("请输入第二个数字:");
            string number2 = Console.ReadLine();
            int numberTwo = Int32.Parse(number2);
            int result=0;
            if (sign == "+") { result = numberOne + numberTwo; }
            else if (sign == "-") { result = numberOne - numberTwo; }
            else if (sign == "*") { result = numberOne * numberTwo; }
            else if (sign == "/") { result = numberOne / numberTwo; }
            Console.WriteLine("两数运算最终的结果是：");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
