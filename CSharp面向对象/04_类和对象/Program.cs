using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_类和对象
{
    class Customer
    {
        //字段
        public string Name;
        public int Age;
        public string createTime;

        //方法
        //无参构造函数
        public Customer()
        {
            Console.WriteLine("我是无参构造函数");
        }
        //有参构造函数
        public Customer(string name,int age,string createTime)
        {
            this.Name = name;
            this.Age = age;
            this.createTime = createTime;
        }
        public void ShowInfo()
        {
            Console.WriteLine("姓名:{0},年龄:{1},创建时间:{2}", Name, Age, createTime);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer("zhangsan",12,"20050909");
            Customer c2;//声明对象
            c2 = new Customer();//实例化对象

            //c1.ShowInfo();
            //c2.ShowInfo();   //默认值为空或0

            //Vehicle car1 = new Vehicle("宝马", 100, 300, 1500.5f);
            //car1.Run();
            //car1.Stop();

            Vector3 v1=new Vector3(1.0f, 2.0f, 3.0f);
            Vector3 v2=new Vector3(4.0f, 5.0f, 6.0f);
            v1.ShowInfo();
            v2.ShowInfo();
            Console.WriteLine("v1的长度为:{0}", v1.Length());
            Console.WriteLine("v1和v2的距离为:{0}", v1.Distance(v2));



            //属性的使用
            Vector3 v3 = new Vector3();
            v3.X = 10.0f;
            Console.WriteLine("v3的X值为:{0}", v3.X);
        }
    }

}
