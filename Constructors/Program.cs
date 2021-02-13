using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { ID = 1, FirstName = "Ömer Faruk", LastName = "Çelik", City = "İstanbul" };

            Customer customer2 = new Customer(2, "Engin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer();
            customer3.ID = 3;
        }
    }
}
