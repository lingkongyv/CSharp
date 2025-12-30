using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_排序
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Program program = new Program();

            Console.WriteLine("请输入要输入多少个数字：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("请输入{0}个数字：", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Array.Sort(arr);

            //冒泡
            //program.BubbleSort(arr);
            BubbleSort(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //交换
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

    }
}
