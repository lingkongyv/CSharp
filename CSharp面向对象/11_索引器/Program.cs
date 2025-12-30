using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_索引器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr[2]);

            //Test t = new Test();
            //t[0]= "张三";
            //t[1]= "李四";
            //t[2]= "王五";
            //t[3]= "赵六";

            //Console.WriteLine(t[0]);

            Week week = new Week();
            Console.WriteLine(week["Wednesday"]);

        }
    }
}
