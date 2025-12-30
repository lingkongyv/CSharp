using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_if语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 16 && age<=30)
            {
                Console.WriteLine("可以进入");
                if (age %2 == 1)
                {
                    Console.WriteLine("可以抽奖");
                }
                else
                {
                    Console.WriteLine("不可以抽奖");
                }

            }
            else
            {
                Console.WriteLine("不可以进入");
            }

        }
    }
}
