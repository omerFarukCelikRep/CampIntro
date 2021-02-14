using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] keyItems;
        TValue[] valueItems;
        public TKey[] Key { get { return keyItems; } }
        public TValue[] Value { get { return valueItems; } }
        public int Length { get { return keyItems.Length; } }
        public MyDictionary()
        {
            keyItems = new TKey[0];
            valueItems = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            Array.Resize<TKey>(ref keyItems, Length + 1);
            Array.Resize<TValue>(ref valueItems, Length + 1);

            keyItems[Length - 1] = key;
            valueItems[Length - 1] = value;
        }
    }
}
