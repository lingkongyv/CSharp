using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 0:
                    Console.WriteLine(a + b);
                    break;
                case 1:
                    Console.WriteLine(a - b);
                    break;
                case 2:
                    Console.WriteLine(a * b);
                    break;
                case 3:
                    Console.WriteLine(a / b);
                    break;
            }

        }
    }
}
