using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_索引器
{
    internal class Test
    {
        private string[] name = new string[10];
        // 定义索引器
        public string this[int index]
        {
            get  //取值
            {
                return name[index];
            }
            set  //赋值
            {
                name[index]=value; ;
            }
        }
    }
}
