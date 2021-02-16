﻿using IntefaceAbstractDemo.Abstract;
using IntefaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntefaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer); 
            }
            else
            {
                throw new Exception("Not a Valid Exception");
            }
        }
    }
}
