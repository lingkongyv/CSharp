using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_接口
{
    internal interface Fly
    {
        //接口里面不能包含数据成员

        // 接口中的方法默认是 public 和 abstract 的
        // 不能有方法体
        void Fly();
        void FlyAttack();
    }
}
