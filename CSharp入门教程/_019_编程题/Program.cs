using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 80000;
            //int year = 2006;
            //while (n < 200000)
            //{
            //    n = (int)(n * 1.25);
            //    year++;
            //}
            //Console.WriteLine(year);


            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1,sum=0;
            while (i < n + 1)
            {
                sum += Convert.ToInt32(Console.ReadLine());
                i++;
            }
            double aveAge = 1.0 * sum / n;
            aveAge = ((int)(aveAge * 100)) / 100.0;
            Console.WriteLine(aveAge);

        }
    }
}
