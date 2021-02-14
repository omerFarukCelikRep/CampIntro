using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class ApplyingManager
    {
        public void Apply(ICreditManager creditManager)
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();

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
