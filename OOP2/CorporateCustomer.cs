using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Inheritance => Miras 
    public class CorporateCustomer : Customer
    {
        public int ID { get; set; }
        public string CustomerNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
