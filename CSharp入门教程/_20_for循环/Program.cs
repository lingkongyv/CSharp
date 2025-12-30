using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_for循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for循环的一般格式
            // for(初始化表达式; 条件表达式; 迭代表达式)
            // {
            //     循环体语句;
            // }
            // 输出1-10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
