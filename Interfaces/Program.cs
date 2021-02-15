using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfacesIntro();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { ID = 1, FirstName = "Ömer Faruk", LastName = "Çelik", Address = "İstanbul" });

            Student student = new Student();
            student.ID = 3;
            student.FirstName = "Ali";
            student.LastName = "Veli";
            student.Departmant = "Software Engineering";

            personManager.Add(student);
        }
    }
}
