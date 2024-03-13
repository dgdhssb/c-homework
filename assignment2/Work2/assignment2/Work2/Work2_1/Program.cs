using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2_1_PrimeFactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个大于1的数字：");
            string str=Console.ReadLine();
            int num=Int32.Parse(str);
            PrimeFactors(num);
            Console.ReadLine();
        }

        static void PrimeFactors(int num)
        {
            if(num == 2)
            {
                Console.WriteLine(num);
                return;
            }
            for (int factor=2;factor*factor<=num;factor++)
            {
                if(num%factor==0)
                {
                    Console.WriteLine(factor+" ");
                    num /= factor;
                    factor--;
                }
            }
            if (num > 1)
            {
                Console.WriteLine(num + " ");
            }
        }

    }
}
