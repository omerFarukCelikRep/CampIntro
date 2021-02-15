using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfacesIntro();
            InterfacesIntro2();

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal() };

            foreach (ICustomerDal item in customerDals)
            {
                item.Add();
            }
        }

        private static void InterfacesIntro2()
        {
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
