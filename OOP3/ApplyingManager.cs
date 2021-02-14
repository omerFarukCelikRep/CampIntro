using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class ApplyingManager
    {
        //Method Injection
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();
            loggerService.Log();

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
