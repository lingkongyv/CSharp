using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_函数方法
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = is_SU(num);
            if (result)
            {
                Console.WriteLine("{0}是素数", num);
            }
            else
            {
                Console.WriteLine("{0}不是素数", num);
            }

        }
        static bool is_SU(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
