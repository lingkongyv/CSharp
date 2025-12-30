using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_虚方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            enemy.Move();
            enemy.Attack();
            Boss boss = new Boss();
            boss.Move();
            boss.Attack(); //调用的是子类的方法  隐藏了父类的方法

            //声明为父类  但是实例化为子类  只能调用父类的方法 不能调用子类特有的方法

            //实例化的时候是什么类型，调用的方法就是哪一个
            Enemy enemy1 = new Boss();
            enemy1.Move();

            // 不能调用子类特有的方法
            //enemy1.Skill();  //报错

            //反过来就不行  子类不能实例化为父类
            //Boss boss1 = new Enemy(); //报错

        }
    }
}
