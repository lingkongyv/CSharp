using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane p = new Plane();
            p.Fly();
            p.FlyAttack();

            //使用接口类型来接收对象
            //接口类型的变量可以指向实现该接口的任意类的对象
            //接口类型的变量只能调用接口中定义的方法
            //接口类型的变量不能调用实现类中定义的方法
            Fly fly;
            
            fly = new Bird();
            fly.Fly();
            fly.FlyAttack();

            fly = new Plane();
            fly.Fly();
            fly.FlyAttack();


        }
    }
}
