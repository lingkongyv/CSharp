using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_调试和错误排查
{
    internal class Program
    {
        static int add(int a , int b)
        {
            //可通过断点调试
            int result = a + b;
            //Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            //int 121 = 10;
            //会出现语法错误

            int a = 120;
            int b = 13;

            int result= add(a, b);

            Console.WriteLine(result);
        }
    }
}
