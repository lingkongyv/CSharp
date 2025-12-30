using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Equals判断相等
{
    class Student
    {
        public int id;
        public String name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //判断值类型的变量，比较的是值是否相等
            int a = 10;
            int b = 10;
            Console.WriteLine(a.Equals(b)); // True

            String str1 = "hello";
            String str2 = "hello";
            Console.WriteLine(str1.Equals(str2)); // True

            //判断引用类型的变量 ，默认情况下，比较的是引用地址是否相等
            Student stu1 = new Student(1, "张三");
            Student stu2 = new Student(1, "张三");
            Console.WriteLine(stu1.Equals(stu2)); // False 

            //比较的是值是否相等
            Console.WriteLine(stu1.id.Equals(stu2.id));  // True
        }
    }
}
