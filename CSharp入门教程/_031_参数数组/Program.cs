using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_参数数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = Sum(arr);
            Console.WriteLine("数组元素的和为：{0}", sum);

            int sum2 = Sum2(1, 2, 3, 4, 5, 6, 7, 8, 9); //直接传递多个参数
            Console.WriteLine("和为：{0}", sum2);
        }
        static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int item in a)
            {
                sum += item;
            }
            return sum;
        }

        // 重载Sum方法，处理double类型数组
        static double Sum(double[] a)
        {
            double sum = 0;
            foreach (double item in a)
            {
                sum += item;
            }
            return sum;
        }

        static int Sum2(params int[] a) //可以传递任意数量的参数，包括0个参数
        {
            int sum = 0;
            foreach (int item in a)
            {
                sum += item;
            }
            return sum;
        }
    }
}
