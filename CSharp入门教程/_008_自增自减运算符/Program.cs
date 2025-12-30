using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_自增自减运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++; //先赋值后自增
            Console.WriteLine("a={0},b={1}", a, b); //a=11,b=10
            int c = ++a; //先自增后赋值
            Console.WriteLine("a={0},c={1}", a, c); //a=12,c=12

        }
    }
}
