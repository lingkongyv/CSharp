using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_接口
{
    internal class Bird : Fly
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
        public void FlyAttack()
        {
            Console.WriteLine("鸟在攻击");
        }
    }
}
