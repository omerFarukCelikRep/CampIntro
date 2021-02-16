using IntefaceAbstractDemo.Abstract;
using IntefaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntefaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
