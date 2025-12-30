using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_运算符重载
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("张三", 20);
            Student s2 = new Student("张三", 20);
            Console.WriteLine(s1 == s2); // True
        }
    }
}
