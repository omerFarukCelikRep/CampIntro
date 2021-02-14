using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Ömer");

            Console.WriteLine(myList.Length);

            myList.Add("Faruk");
            Console.WriteLine(myList.Length);

            foreach (string item in myList.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
