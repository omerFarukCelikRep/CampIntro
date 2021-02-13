using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;

            number1 = number2;
            number2 = 65;

            //number1 ?? => 30

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };

            numbers1 = numbers2;
            numbers2[0] = 999;

            //numbers1[0]   ??  => 999

            /*
             * Value Types => Değer Tipler
             * int
             * decimal
             * float
             * double
             * bool
             * enum
             * 
             * Reference Types => Referans Tipler
             * Array
             * Class
             * Interface
             */

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName); // Derin

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "223456487";

            Employee employee = new Employee();

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(person3.FirstName); // Salih
            Console.WriteLine(((Customer)person3).CreditCardNumber); // 223456487
        }
    }
}
