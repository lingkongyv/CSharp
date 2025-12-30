using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要输入多少个数字：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("请输入{0}个有序数字：", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("请输入要插入的数字：");
            int num = Convert.ToInt32(Console.ReadLine());

            int index = arr.Length; // 默认插入到最后

            // 查找插入位置
            for (int i = 0; i < arr.Length; i++)
            {
                if (num <= arr[i])
                {
                    index = i;
                    break;
                }
            }

            // 如果数字比所有数都大，就插入到最后
            if (index == arr.Length)
            {
                index = arr.Length;
            }

            int[] newArr = new int[arr.Length + 1];

            // 复制插入位置前的元素
            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }

            // 插入新数字
            newArr[index] = num;

            // 复制插入位置后的元素
            for (int i = index; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

            Console.WriteLine("插入后的数组为：");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
            Console.WriteLine(); // 换行
        }
    }
}