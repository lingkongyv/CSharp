using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_接口
{
    //一个类可以实现多个接口，但是只能继承一个类
    internal class Class1 : Bird, Interface2,Interface1
    {
        public void Method1()
        {
            throw new NotImplementedException();
        }

        public void Method2()
        {
            throw new NotImplementedException();
        }
    }
}
