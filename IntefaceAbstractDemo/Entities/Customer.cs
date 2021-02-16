using IntefaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntefaceAbstractDemo.Entities
{
    public class Customer : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityID { get; set; }

    }
}
