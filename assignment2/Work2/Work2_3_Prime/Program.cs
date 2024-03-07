using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2_3_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[101];
            for(int i = 2;i<=100;i++)
            {
                arr[i]= i;
            }

            for(int i = 2; i <= 10; i++)
            {
                for(int j = 2*i; j<=100; j+=i)
                {
                    if (arr[j]!=0)
                    {
                        arr[j]=0;
                    }  
                }
            }

            for(int i= 2; i<=100; i++)
            {
                if (arr[i]!=0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
