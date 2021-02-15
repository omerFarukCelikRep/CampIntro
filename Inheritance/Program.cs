using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir nesne bir kere inherite edilebilir 
            //Ama bşrden fazla implementasyon yapılabilir
            Person[] people = new Person[]
            {
                new Customer { FirstName = "Ali" },
                new Student { FirstName = "Veli" },
                new Person { FirstName = "Salih" }
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
