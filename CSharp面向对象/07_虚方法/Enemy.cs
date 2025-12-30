using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_虚方法
{
    internal class Enemy
    {
        // 虚方法 virtual
        public virtual void Move()
        {
            Console.WriteLine("敌人移动");
        }

        public void Attack()
        {
            Console.WriteLine("敌人攻击");
        }
    }
}
