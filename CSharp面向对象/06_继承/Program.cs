using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_继承
{
   class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal类的构造函数被调用");
        }
        public void Eat()
        {
            Console.WriteLine("吃饭");
        }
    }

    //c#不支持多继承，一个类只能继承一个父类
    // Cat继承Animal类
    class Cat :Animal
    {
        public Cat()
        {
            Console.WriteLine("Cat类的构造函数被调用");
        }
        public void Meow()
        {
            Console.WriteLine("喵喵叫");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //cat.Eat();
            //cat.Meow();

            Boss boss1 = new Boss(1000,20, 200);
            boss1.ShowInfo();
            boss1.Move();
            boss1.AI();
            boss1.Skill();

        }
    }
}
