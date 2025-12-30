using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            //int ge = num % 10;
            //int shi = (num / 10) % 10;
            //int bai = num / 100;
            //Console.WriteLine("{0},{1},{2}", ge, shi, bai);

            int shi = (num / 10) % 10;
            int qian = (num / 1000) % 10;
            int newNum = qian*10+ shi;
            char c = (char)newNum;
            Console.WriteLine(c);

        }
    }
}
