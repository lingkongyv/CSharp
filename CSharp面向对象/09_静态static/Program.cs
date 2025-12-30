using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_静态static
{
    class Test
    {
        public int hp;
        public static int count;

        // 静态方法
        // 静态方法属于类本身，可以在不创建类的实例的情况下调用
        // 静态方法不能访问类的实例成员（非静态成员）
        public static void Show()
        {
            //this.hp; // 错误，静态方法不能访问实例成员
            count = 110;
            Console.WriteLine("这是一个静态方法");
        }
    }

    static class Test1
    {
        // 静态类只能包含静态成员(静态字段，方法等)
        // 静态类不能被实例化
        public static void Show()
        {
            Console.WriteLine("这是一个静态类的静态方法");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test1 = new Test();
            test1.hp = 100;
            Test test2 = new Test();
            test2.hp = 200;
            Console.WriteLine("test1的hp:" + test1.hp);
            Console.WriteLine("test2的hp:" + test2.hp);

            // 类的静态成员只能通过类名访问
            // 静态成员属于类本身，而不属于类的实例
            Test.count = 1;
            Console.WriteLine("Test的count:" + Test.count);

            Test.Show();
            Console.WriteLine("Test的count:" + Test.count);
        }
    }
}
