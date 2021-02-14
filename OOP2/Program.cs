using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID

            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.FirstName = "Ömer Faruk";
            customer1.LastName = "Çelik";
            customer1.IdentityNumber = "1111111111";
            customer1.CustomerNumber = "65651";
            customer1.CompanyName = "?";
        }
    }
}
