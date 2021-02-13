using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {

        }
    }
}
