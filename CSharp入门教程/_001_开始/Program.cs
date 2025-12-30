using System;

namespace _001_开始
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("请输入名字：");
            string name = Console.ReadLine();
            Console.WriteLine("你好，" + name);
            Console.ReadKey();
        }
    }
}
