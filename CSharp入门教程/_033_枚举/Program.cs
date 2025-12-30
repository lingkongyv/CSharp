using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_枚举
{
    internal class Program
    {
        enum RoleType //枚举类型的名字
        {
            //枚举类型的值
            Mage,
            Archer,
            Assassin,
            Tank,
            Support,
            Warrior 
        }
        enum GameState 
        {
           Menu,Running,Pause,Fail,Success
        }
        static void Main(string[] args)
        {
            //1法师(Mage)、2射手(Archer)、3刺客(Assassin)
            //4坦克(Tank)、5辅助(Support)、6战士(Warrior)
            RoleType roleType = RoleType.Mage;
            GameState state = GameState.Running;
            Console.WriteLine(state);
        }
    }
}
