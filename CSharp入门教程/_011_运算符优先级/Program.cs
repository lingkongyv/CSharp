using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_运算符优先级
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 3 + 4 * 5;
            Console.WriteLine(result); // 输出 23，因为乘法优先级高于加法
        }
    }
}
