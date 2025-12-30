using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明数组
            //int[] ages = { 1, 2, 3 };
            //int[] scores = new int[5];
            //char[] array = new char[3];
            //float[] width = new float[5];
            //string[] names = new string[3];

            int[] ages = { 1, 2, 3, 4 };
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }

            //foreach (int temp in ages)
            //{
            //    Console.WriteLine(temp);
            //}

        }
    }
}
