using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_判断非法字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool isValid = true;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] < '0' || str[i] > '9') && (str[i] < 'a' || str[i] > 'z') && (str[i] < 'A' || str[i] > 'Z') && str[i] != '_')
                {
                    isValid = false;
                    break;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("包含非法字符");
            }
            else
            {
                Console.WriteLine("不包含非法字符");

            }
        }
    }
}
