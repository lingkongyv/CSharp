using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_类和对象
{
    internal class Vector3
    {
        //字段
        private float x, y, z;
        public float length;

        //自动属性
        private float w { get; set; }

        //属性
        //只读或者只写
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public float Z
        {
            get { return z; }
            set { z = value; }
        }

        //构造函数
        public Vector3() { }
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //方法
        public void ShowInfo()
        {
            Console.WriteLine("v:({0},{1},{2})", x, y, z);
        }
        public float Length()
        {
            length = (float)Math.Sqrt(x * x + y * y + z * z);
            return length;
        }
        public float Distance(Vector3 v)
        {
            float distance;
            distance = (float)Math.Sqrt(Math.Pow((v.x - x), 2) + Math.Pow((v.y - y), 2) + Math.Pow((v.z - z), 2));
            return distance;
        }
    }
}
