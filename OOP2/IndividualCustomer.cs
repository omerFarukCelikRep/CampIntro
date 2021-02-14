using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Inheritance => Miras
    public class IndividualCustomer : Customer
    {
        public int ID { get; set; }
        public string CustomerNumber { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
