using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_switch语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("绿茶");
            //        break;
            //    case 2:
            //        Console.WriteLine("红茶");
            //        break;
            //    default:
            //        Console.WriteLine("阿萨姆");
            //        break;
            //}
            switch (number)
            {
                case 1: case 2: case 3: case 4: case 5:
                    Console.WriteLine("今天上c++");
                    break;
                case 6: case 7:
                    Console.WriteLine("今天上c#");
                    break;

            }
        }
    }
}
