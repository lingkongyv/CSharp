using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_数学运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 3;
            //Console.WriteLine("变量a:{0},变量b:{1} ",a,b);
            //Console.WriteLine("加法: " + (a + b)); // 13
            //Console.WriteLine("减法: " + (a - b)); // 7
            //Console.WriteLine("乘法: " + (a * b)); // 30
            //Console.WriteLine("除法: " + (a / b)); // 3
            //Console.WriteLine("取余: " + (a % b)); // 1

            //// 浮点数除法
            //double c = 10.0;
            //double d = 3.0;
            //Console.WriteLine("浮点数除法: " + (c / d)); // 3.33333333333333


            Console.WriteLine("请输入一个两位整数: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int tens = num / 10; // 获取十位数
            int units = num % 10; // 获取个位数
            Console.WriteLine("十位数是:{0},个位数是:{1}", tens, units);

        }
    }
}
