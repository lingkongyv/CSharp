using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_继承
{
    internal class Enemy
    {
        protected int HP;
        protected int speed;
        public Enemy()
        {
        }
        public Enemy(int hp, int speed)
        {
            this.HP = hp;
            this.speed = speed;
        }
        public void AI()
        {
            Console.WriteLine("敌人AI逻辑");
        }
        public void Move()
        {
            Console.WriteLine("敌人移动");
        }
    }
}
