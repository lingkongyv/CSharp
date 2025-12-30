using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_全部数据类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //全部数据类型
            //整数类型
            byte b = 1  ;//1字节 0~255
            short s = 2;//2字节 -32768~32767
            int i = 4;//4字节 -21亿~21亿
            long l = 8;//8字节 -9千多亿~9千多亿
            //小数类型
            float f = 4.0f;//4字节 单精度 小数点后6-7位
            double d = 8.0;//8字节 双精度 小数点后15-16位
            decimal m = 16.0m;//16字节 高精度 小数点后28-29位 金额计算
            //字符类型
            char c = 'a';//2字节 单个字符
            //布尔类型
            bool bo = true;//1字节 true/false
            //字符串类型
            string str = "hello";//引用类型 字符串
            Console.WriteLine("byte:" + b);
            Console.WriteLine("short:" + s);
            Console.WriteLine("int:" + i);
            Console.WriteLine("long:" + l);
            Console.WriteLine("float:" + f);
            Console.WriteLine("double:" + d);
            Console.WriteLine("decimal:" + m);
            Console.WriteLine("char:" + c);
            Console.WriteLine("bool:" + bo);
            Console.WriteLine("string:" + str);


            //数字转换成字符串
            string s1 = 123.ToString();
            string s2 = Convert.ToString(12123);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
