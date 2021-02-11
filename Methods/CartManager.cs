using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class CartManager
    {
        //Naming Convention
        //Syntax
        public void Add(Product product)
        {
            Console.WriteLine("Added");
        }

        //Method Overload
        public void Add(string productName, double price, string description)
        {

            Console.WriteLine("Added" + productName);
        }
    }
}
