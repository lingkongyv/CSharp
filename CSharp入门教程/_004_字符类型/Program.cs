using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_字符类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char b = 'a';
            //int a = b;
            //Console.WriteLine(a);

            char a = '1';
            int b = a;
            Console.WriteLine(b);

            // @  1.消除识别转义字符
            //    2.可以用于多行字符串

            Console.WriteLine(@"\\""\\\");   //两个引号表示一个引号

            //字符串的拼接
            string str = "hello";
            string str2 = str + "21";
            Console.WriteLine(str2+123);

            //字符串的输入和输出
            //string str3 = Console.ReadLine();
            //Console.WriteLine("输入的字符串是"+str3);

            //输入数字
            Console.Write("请输入数字：");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入的数字是："+num);

        }
    }
}
