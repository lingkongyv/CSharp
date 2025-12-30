using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_委托
{
    internal class Program
    {

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
        static void Test()
        {
            Console.WriteLine("你好");
        }
        //定义委托不需要函数体
        delegate double MyDelegate(double a, double b);
        delegate void MyDelegate2();
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply(2,3) = {0}", Multiply(2, 3));
            Console.WriteLine("Divide(2,3) = {0}", Divide(2, 3));

            //委托实例化
            MyDelegate myDelegate;
            myDelegate = Multiply;
            Console.WriteLine("myDelegate(2,3) = {0}", myDelegate(2, 3));
            myDelegate = Divide;
            Console.WriteLine("myDelegate(6,3) = {0}", myDelegate(6, 3));

            MyDelegate2 myDelegate2;
            myDelegate2 = Test;
            myDelegate2();

        }
    }
}
