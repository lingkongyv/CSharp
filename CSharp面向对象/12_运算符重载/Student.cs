using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_运算符重载
{
    internal class Student
    {
        private string name;
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // 重载==运算符
        public static bool operator ==(Student s1, Student s2)
        {
            if(s1.name == s2.name && s1.age==s2.age)
            {
                return true;
            }
            return false;
        }

        // 重载!=运算符
        public static bool operator !=(Student s1, Student s2)
        {
            bool result = s1 == s2;
            return !result;
        }

    }
}
