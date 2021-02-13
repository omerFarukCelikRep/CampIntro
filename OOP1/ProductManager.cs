using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        /*
         * CRUD
         * ----------
         * C => Create
         * R => Read
         * U => Update
         * D => Delete 
         */

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Added");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Updated");
        }
    }
}
