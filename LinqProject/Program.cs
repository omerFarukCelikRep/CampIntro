using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryID = 1, CategoryName = "Bilgisayar" },
                new Category { CategoryID = 1, CategoryName = "Telefon" }
            };

            List<Product> products = new List<Product>
            {
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 5 },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 8000, UnitsInStock = 3 },
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 6000, UnitsInStock = 2 },
                new Product { ProductID = 4, CategoryID = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitsInStock = 15 },
                new Product { ProductID = 5, CategoryID = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitsInStock = 0 },
            };

            GetProductsWithoutLinq(products);

            GetProductsWithLinq(products);

            AnyExample(products);

            FindExample(products);

            FindAllAndContainsExample(products);
            WhereWithContainsAndOrderByExample(products);
        }

        private static void WhereWithContainsAndOrderByExample(List<Product> products)
        {
            var whereResult = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var item in whereResult)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindAllAndContainsExample(List<Product> products)
        {
            var findList = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var item in findList)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindExample(List<Product> products)
        {
            var findResult = products.Find(p => p.ProductID == 3);
            Console.WriteLine(findResult);
        }

        private static void AnyExample(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Dell Laptop");
            Console.WriteLine(result);
        }

        private static List<Product> GetProductsWithLinq(List<Product> products)
        {
            //Wtih Linq
           return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();

        }

        private static List<Product> GetProductsWithoutLinq(List<Product> products)
        {
            //Without Linq
            List<Product> filteredProducts = new List<Product>();

            foreach (Product product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
    }
}
