using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = " zhan lingzhi ";
            //for(int i =name.Length-1;i>=0;i--)
            //{
            //    Console.WriteLine(name[i]);
            //}

            name = name.ToUpper();
            Console.WriteLine(name);
            name = name.ToLower();
            Console.WriteLine(name);

            //去除字符串前面的空格和后面的空格
            Console.WriteLine(name.Trim());
            //只去除字符串前面的空格
            Console.WriteLine(name.TrimStart());
            //只去除字符串后面的空格
            Console.WriteLine(name.TrimEnd());

            name = "xiaohong zhangsan xiaolei";
            
            Console.WriteLine(name.Split(' '));   //输出结果是System.String[] ， 表明得到字符串数组

            string[] names = name.Split(' ');
            foreach (string s in names)
            {
                Console.Write(s+",");
            }

        }
    }
}
