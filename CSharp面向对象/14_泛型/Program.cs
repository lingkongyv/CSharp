using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_泛型
{
    //泛型类
    class ClassA<T>  //Type
    {
        private T a;
        private T b;
        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public T Sum()
        {
            dynamic num1 = this.a;
            dynamic num2 = this.b;
            return (T)(num1 + num2);   
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA<int> class1 = new ClassA<int>(10, 20);
            Console.WriteLine(class1.Sum());

            ClassA<double> class2 = new ClassA<double>(10.5, 20.3);
            Console.WriteLine(class2.Sum());

            //任何一个类中都有ToString()方法
            Program p = new Program();
            Console.WriteLine(p.ToString()); 
            Console.WriteLine(p);

            Console.WriteLine(GeTSum<int>(40, 20));
            Console.WriteLine(GeTSum<double>(4.15, 20.3));
        }
         
        public static T GeTSum<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return (T)(num1 + num2);
        }
    }
}
