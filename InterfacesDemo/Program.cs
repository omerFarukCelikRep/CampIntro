using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            //Interface Segregation
            IWorker[] workers = new IWorker[] { new Manager(), new Worker(), new Robot() };

            foreach (IWorker worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] { new Worker(), new Manager() };

            foreach (IEat eat in eats)
            {
                eat.Eat();
            }
        }
    }
}
