using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入两个数字，每行一个");
            int a = 0, b = 0;
            while (true)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("捕获到异常：" + e.Message);
                    Console.WriteLine("请重新输入");
                }
            }
            Console.WriteLine("两个数字之和为：{0}" ,a + b);

        }
    }
}
