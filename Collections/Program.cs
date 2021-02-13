using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = new string[] {"Engin", "Murat", "Kerem", "Halil" };

            //List<string> names = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            List<string> names = new List<string>();
            names.Add("Engin");
            names.Add("Murat");
            names.Add("Kerem");
            names.Add("Halil");

            names.Add("İlker");

        }
    }
}
