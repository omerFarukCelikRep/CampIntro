using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        public int Length { get { return items.Length; } }
        public T[] Items { get { return items; } }
        //Constructor
        public MyList()
        {
            items = new T[] { };
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
