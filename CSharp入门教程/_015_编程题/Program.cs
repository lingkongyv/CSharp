using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_编程题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            if (k == 0)
            {
                int temp = (int)m; //取整数部分
                Console.WriteLine(temp);
            }
            else
            {
                double temp =((int)((m + 0.05) * 10))/ 10.0; //四舍五入保留一位小数
            }
        }

    }
}
