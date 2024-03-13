using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2_4_Toeplitz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=100,m=100;
            Console.WriteLine("请输入矩阵的行数n:");
            n=Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入矩阵的列数m:");
            m=Int32.Parse(Console.ReadLine());
            int[,] arr = new int[n,m];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine($"请输入第{i+1}行数字(每个数字之间空格)：");
                string input = Console.ReadLine();
                string[] numbers = input.Split(' '); 
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Int32.Parse(numbers[j]);
                }
            }
            bool Iam = IfToeplitz(arr, n, m);
            string name;
            name=(Iam == true) ?"是":"不是" ;
            Console.WriteLine($"这个矩阵{name}托普利茨矩阵");
            Console.ReadKey();
        }
        static bool IfToeplitz(int[,] arr,int n,int m)
        {
            bool Iam = true;
            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<m-1;j++)
                {
                    if (arr[i, j] != arr[i+1,j+1])
                    {
                        Iam=false; break;
                    }
                }
            } 
            //int num = arr[0, 0];
            //for (int i = 0, j = 0; i <n&&j <m;i++,j++)
            //{
            //    if (arr[i,j] != num)
            //    {
            //        Iam = false;
            //    }
            //}
            return Iam;
        }
    }
}
