using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Referans tutsun ve uygulaması zorunlu olan operasyonları tutsun diye interface oluşturduk
             * 
             * Alternatif sistemler için bir şablon ve referans tutucu görevi görüyor.
             * 
             * Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
             */


            ICreditManager consumerCreditManager = new ConsumerCreditManager();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

            ApplyingManager applyingManager = new ApplyingManager();
            //applyingManager.Apply(housingCreditManager, new DatabaseLoggerService());
            applyingManager.Apply(housingCreditManager, loggerServices);

            List<ICreditManager> credits = new List<ICreditManager>() { consumerCreditManager, vehicleCreditManager};

            applyingManager.Inform(credits);
        }
    }
}
