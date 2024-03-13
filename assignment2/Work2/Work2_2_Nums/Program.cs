using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2_2_Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums= {4,5,6,8,2,3,45,26,89,16};
            int max=MaxNum(nums);
            Console.WriteLine("数组的最大值是："+max);
            int min=MinNum(nums);
            Console.WriteLine("数组的最小值是："+min);
            double average=AverageNum(nums);
            Console.WriteLine("数组的平均值是："+average);
            int sum=SumNum(nums);
            Console.WriteLine("数组的和是："+sum);
            Console.ReadKey();
        }
        //最大值
        static int MaxNum(int[] nums)
        {
            int length=nums.Length;
            int max = nums[0];
            for(int i=0; i<length; i++) 
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }   
        //最小值
        static int MinNum(int[] nums)
        {
            int length=nums.Length;
            int min = nums[0];
            for (int i=0; i<length;i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }
        //平均值
        static double AverageNum(int[] nums)
        {
            int length=nums.Length;
            double sum=0;
            double average;
            foreach(int i in nums)
            {
                sum+=i;
            }
            average=sum/length;
            return average;
        }
        //和
        static int SumNum(int[] nums)
        {
            int sum=0;
            foreach(int i in nums)
            {
                sum+=i;
            }
            return sum;
        }
    }
}
