using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_继承
{
    internal class Boss:Enemy
    {
        private int attack;
        public Boss(int hp, int attack,int speed)
        {
            this.attack = attack;
            this.HP = hp;
            this.speed = speed;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Boss信息:生命{0}", HP);
            Console.WriteLine("Boss信息:速度{0}", speed);
            Console.WriteLine("Boss信息:攻击力{0}", attack);
        }
        public void Skill()
        {
            Console.WriteLine("Boss释放技能:无敌风火轮");
        }
    }
}
