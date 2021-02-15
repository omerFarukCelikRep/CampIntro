using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel Ekleme Kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
}
