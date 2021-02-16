using IntefaceAbstractDemo.Abstract;
using IntefaceAbstractDemo.Adapters;
using IntefaceAbstractDemo.Concrete;
using IntefaceAbstractDemo.Entities;
using System;

namespace IntefaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1994, 9, 15), FirstName = "Ömer Faruk", LastName = "Çelik", NationalityID = "12345678901" });
        }
    }
}
