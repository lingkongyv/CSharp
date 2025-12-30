using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //与或非  && ||  !
            if(3<4 && 4<5)
            {
                Console.WriteLine("条件成立");
            }
            if(3<4 || 4>5)
            {
                Console.WriteLine("条件成立");
            }
            bool c = 3 < 4;
            Console.WriteLine(!c);

            Console.Write("请输入你的年龄：");
            int age=Convert.ToInt32(Console.ReadLine());
            if(age>=18 && age<=60)
            {
                Console.WriteLine("你是青年");
            }
            else
            {
                Console.WriteLine("你不是青年");
            }

        }
    }
}
