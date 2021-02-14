using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class ApplyingManager
    {
        //Method Injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log(); 
            }

        }

        public void Inform(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
