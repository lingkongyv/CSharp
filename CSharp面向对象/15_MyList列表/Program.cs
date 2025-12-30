using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_MyList列表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(40);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]+" ");
            }

            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);

            //Console.WriteLine(list[12]);

            //list.RemoveAt(3);

           
            Console.WriteLine("IndexOf(20): " + list.IndexOf(20));


            list.Clear();

            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);
        }
    }
}
