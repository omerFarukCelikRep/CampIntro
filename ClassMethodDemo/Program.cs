using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.FirstName = "Ali";
            customer1.LastName = "Bakan";

            Customer customer2 = new Customer();
            customer2.ID = 1;
            customer2.FirstName = "Veli";
            customer2.LastName = "Soran";

            CustomerManager customerManager = new CustomerManager();


            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Customer[] customers = customerManager.GetCustomers();
            foreach (Customer item in customers)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            
        }
    }
}
