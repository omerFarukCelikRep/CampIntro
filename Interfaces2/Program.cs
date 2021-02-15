using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface'ler new'lenemez
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
            projectManager.Add(customerManager);
        }
    }
}
