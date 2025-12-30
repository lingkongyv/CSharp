using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_虚方法
{
    internal class Boss:Enemy
    {
        // 重写父类的虚方法 override
        public override void Move() 
        {
            Console.WriteLine("Boss发动瞬移");
        }

        public void Skill()
        {
            Console.WriteLine("Boss释放技能:闪电旋风劈");
        }

        // 非重写父类的方法,而是隐藏父类的方法
        public void Attack()
        {
            Console.WriteLine("Boss疯狂攻击");
        }
    }
}
