using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_抽象类
{
    // 定义一个抽象类 Enemy
    abstract class Enemy
    {
        private int hp;
        private int speed;
        public void Move()
        {
            Console.WriteLine("Enemy is moving at speed: " + speed);
        }

        // 定义一个抽象方法 Attack
        // 抽象方法没有方法体，必须在派生类中实现
        public abstract void Attack();
    }
}
