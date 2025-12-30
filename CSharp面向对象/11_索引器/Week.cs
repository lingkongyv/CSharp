using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_索引器
{
    internal class Week
    {
        private string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday"};

        // 根据星期几返回对应的数字
        private int GetDay(string day)
        {
            int i = 0;
            foreach (string item in days)
            {

                if (item == day)
                {
                    return i+1;
                }
                i++;
            }
            return -1;
        }

        // 定义索引器
        public int this[string day]
        {
            get  //取值
            {
                return GetDay(day);
            }
        }
    }
}
