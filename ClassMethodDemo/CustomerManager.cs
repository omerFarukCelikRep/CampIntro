using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        Customer[] customers;

        public Customer[] GetCustomers()
        {
            return customers;
        }

        public void Add(Customer customer)
        {
            //Müşteri Eklemek için önce müşteri dizisinin uzunluğunu 1 arttırıyoruz
            Array.Resize<Customer>(ref customers, customers.Length + 1);

            //Dizinin son elemanına yeni müşteriyi atıyoruz
            customers[customers.Length - 1] = customer;
        }

        public void Delete(Customer customer)
        {
            for(int i = 0; i < customers.Length; i++)
            {
                if (customers[i].ID == customer.ID)
                {
                    Customer tmp;
                    tmp = customers[i];
                    customers[i] = customers[customers.Length - 1];
                    customers[customers.Length - 1] = tmp;

                    Array.Resize<Customer>(ref customers, customers.Length - 1);

                }
            }
        }
    }
}
