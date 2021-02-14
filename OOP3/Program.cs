using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCreditManager = new ConsumerCreditManager();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager housingCreditManager = new HousingCreditManager();

            ApplyingManager applyingManager = new ApplyingManager();
            applyingManager.Apply(housingCreditManager);

            List<ICreditManager> credits = new List<ICreditManager>() { consumerCreditManager, vehicleCreditManager};

            applyingManager.Inform(credits);
        }
    }
}
