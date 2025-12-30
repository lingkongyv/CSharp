using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int year = Convert.ToInt32(Console.ReadLine());
            //if(year % 4 ==0 && year % 100 != 0 || year %400 == 0)
            //{
            //    Console.WriteLine("{0}是闰年", year);
            //}
            //else
            //{
            //    Console.WriteLine("{0}不是闰年", year);
            //}

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
            //Console.WriteLine("最大值的平方是{0}", max*max);

            char sex = Convert.ToChar(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            if (sex == 'F')
            {
                //Console.WriteLine("800米长跑");
                string project = "800米长跑";
                if (num % 2 == 0)
                {
                    //Console.WriteLine("跳绳");
                    project += " 跳绳";
                }
                else
                {
                    //Console.WriteLine("踢毽子");
                    project += " 踢毽子";
                }
                Console.WriteLine(project);
            }
            else
            {
                Console.WriteLine("1000米长跑");
                if (num % 2 == 0)
                {
                    Console.WriteLine("跳远");
                }
                else
                {
                    Console.WriteLine("俯卧撑");
                }
            }

        }
    }
}
