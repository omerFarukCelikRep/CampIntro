using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri Ekleme Kodları
            Console.WriteLine("Müşteri Eklendi");
        }
    }
}
