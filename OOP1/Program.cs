using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.ProductName = "Masa";
            product1.CategoryID = 2; //2 => Mobilya Kategorisi
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                ID = 2,
                CategoryID = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase  //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
