using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_值和引用
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "san";
            string s2= "san";
            s1 = "123";
            Console.WriteLine("s1:{0},s2:{1}", s1, s2);

        }
    }
}
