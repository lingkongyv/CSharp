using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_结构体
{
    struct Students
    {
        public string name;
        public int age;
        public string sex;
    }
    struct Position
    {
        public int x;
        public int y;
        public int z;
        public Position(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void GetPos()
        {
            Console.WriteLine("({0},{1},{2})", x, y, z);
        }
    }
    struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void SetVec(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float Distance()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Students[] stu1 = new Students[2];
            //stu1[0].name = "张三";
            //stu1[0].age = 18;
            //stu1[0].sex = "男";

            //Position pos1 = new Position(2,3,4);
            //pos1.GetPos();

            Vector3 v1 = new Vector3(1, 2, 3);
            v1.SetVec(3,4,5);
            Console.WriteLine(v1.Distance());
        }
    }
}
