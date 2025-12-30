using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_类和对象
{
    internal class Vehicle
    {
        public string brand;
        public int speed;
        public int maxSpeed;
        public float weight;

        public Vehicle() { }
        public Vehicle(string brand, int speed, int maxSpeed, float weight)
        {
            this.brand = brand;
            this.speed = speed;
            this.maxSpeed = maxSpeed;
            this.weight = weight;
        }
        public void Run()
        {
            Console.WriteLine("{0}正在以{1}的速度行驶，最大速度为{2}", brand, speed, maxSpeed);
        }
        public void Stop()
        {
            Console.WriteLine("{0}已经停止行驶", brand);
        }

    }
}
