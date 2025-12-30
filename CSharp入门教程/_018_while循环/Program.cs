using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int HP=100;
            //while(HP>0)
            //{
            //    HP -= 3;
            //    Console.WriteLine("当前血量为："+HP);
            //}

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //while(a<b+1)
            //{
            //    a++;
            //    if(a%2==0)
            //    {
            //        Console.WriteLine(a);
            //    }
            //}

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(n!=1)
            {
                if (n % 2 != 0)
                {
                    n = 3 * n + 1;
                }
                else
                {
                    n = n / 2;
                }
                i++;
            }
            Console.WriteLine(i);

        }
    }
}
