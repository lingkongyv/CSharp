using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_变量研究
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10,temp=0;

            Console.WriteLine("交换前：a={0},b={1}", a, b);

            temp = a;
            a = b;
            b = temp;

            //a = a + b;
            //b = a - b;
            //a = a - b;

            Console.WriteLine("交换后：a={0},b={1}", a, b);

            //字符串格式化输出
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
        }
    }
}
