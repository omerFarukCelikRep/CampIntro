﻿using IntefaceAbstractDemo.Abstract;
using IntefaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntefaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
