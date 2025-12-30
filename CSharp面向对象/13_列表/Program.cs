using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_列表
{
    internal class Program
    {
        static void ShowList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("列表的容量：" + list.Capacity);
            Console.WriteLine("列表的元素个数：" + list.Count);
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>(3) {123,123,43};
            ShowList(list);

            list.Add(764);//添加元素
            Console.WriteLine("加了一个元素之后：");
            ShowList(list);

            list.Remove(43); //移除元素
            Console.WriteLine("移除一个元素之后：");
            ShowList(list);

            list.Insert(1, 999); //在索引1的位置插入999
            Console.WriteLine("在索引1的位置插入一个元素之后：");
            ShowList(list);

            list.RemoveAt(0); //移除索引0位置的元素
            Console.WriteLine("移除索引0位置的元素之后：");
            ShowList(list);

            list.Sort(); //排序
            Console.WriteLine("排序之后：");
            ShowList(list);

            Console.WriteLine("从前往后查找元素999的索引位置:" + list.IndexOf(999)); //查找元素999的索引位置
            Console.WriteLine("从后往前查找元素123的索引位置:" + list.LastIndexOf(123)); //从后往前查找元素123的索引位置

            list.Clear();//清空列表
        }
    }

}
