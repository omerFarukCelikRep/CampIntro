﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
