using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_递归练习
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a= Convert.ToInt32(Console.ReadLine());
            int result = Factorial(a);
            Console.WriteLine("{0}的阶乘结果为：{1}", a,result);
            

            Console.WriteLine("1到{0}的阶乘和为：{1}", a,F2(a));
        }
        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        static int F1(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * F1(num - 1);
        }
        static int F2(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return F2(num-1) + F1(num);
        }
    }
}
