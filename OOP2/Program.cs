using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            //Bireysel Müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.CustomerNumber = "12346";
            customer1.FirstName = "Ömer Faruk";
            customer1.LastName = "Çelik";
            customer1.IdentityNumber = "1341546";

            //Kurumsal Müşteri
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNumber = "34651";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "54613246546";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);


        }
    }
}
