using IntefaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntefaceAbstractDemo.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saved to Database : " + customer.FirstName);
        }
    }
}
