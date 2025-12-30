using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_字符读取
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //读取字符
            //char c = (char)Console.Read();
            //Console.WriteLine(c);
            char c=' ';
            int sum = 0;
            do
            {
                c = (char)Console.Read();
                if(c>='0'&&c<='9')
                {
                    int num= c - '0';
                    sum += num;
                }
            } while (c!='@');
            Console.WriteLine("sum="+sum);
        }
    }
}
