using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_do_while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do...while循环的一般格式
            // do
            // {
            //     循环体语句;
            // } while (条件表达式);
            // 输出1-10
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            Console.ReadKey();

        }
    }
}
