﻿using IntefaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntefaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        void CheckIfRealPerson(Customer customer);
    }
}
