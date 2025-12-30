using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_异常处理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            try //可能发生异常的代码放在try块中
            {
                a[4] = 100; // 这里会发生数组下标越界异常
                Console.WriteLine(a[4]);
            }
            catch (IndexOutOfRangeException ex) //捕获异常并处理
            {
                //出现异常之后的处理代码
                Console.WriteLine("捕获到异常：" + ex.Message);
            }
            catch(FileLoadException ex)
            {
                Console.WriteLine("捕获到文件加载异常：" + ex.Message);
            }
            finally //无论是否发生异常，finally块中的代码都会执行
            {
                Console.WriteLine("程序结束");
            }
        }

    }
}
