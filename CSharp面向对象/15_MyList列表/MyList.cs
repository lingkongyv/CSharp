using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_MyList列表
{
    internal class MyList<T>
    {
        //私有字段
        private T[] data = new T[0];
        private int count = 0; // 元素个数

        //公有属性和方法
        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }

        //添加元素的方法
        public void Add(T item)
        {
            if(data.Length == 0)
            {
                data = new T[4];
            }

            //添加元素之前，判断容量是否足够
            if(data.Length == count)
            {
                //扩容
                T[] temp = new T[data.Length * 2];
                for(int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            data[count] = item;
            count++;    
        }

        //插入数据
        public void Insert(int index, T item)
        {
            if(index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("索引参数超出范围");
            }
            //判断容量是否足够
            if(data.Length == count)
            {
                //扩容
                T[] temp = new T[data.Length * 2];
                for(int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            //移动元素
            for(int i = count; i > index; i--)
            {
                data[i] = data[i - 1];
            }
            data[index] = item;
            count++;
        }

        //移除数据
        public void RemoveAt(int index)
        {
            if(index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("索引参数超出范围");
            }
            //移动元素
            for(int i = index; i < count - 1; i++)
            {
                data[i] = data[i + 1];
            }
            count--;
        }

        //查找元素索引
        public int IndexOf(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if(data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1; //未找到
        }
        public int LastIndexOf(T item)
        {
            for(int i = count - 1; i >= 0; i--)
            {
                if(data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1; //未找到
        }

        //排序
        public void Sort()
        {
           Array.Sort(data, 0, count);
        }

        //清空列表
        public void Clear()
        {
            count = 0;
        }

        //索引器
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= count)
                {
                    //抛出异常
                    throw new ArgumentOutOfRangeException("索引参数超出范围");
                }
                return data[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    //抛出异常
                    throw new ArgumentOutOfRangeException("索引参数超出范围");
                }
                data[index] = value;
            }
        }
    }
}
