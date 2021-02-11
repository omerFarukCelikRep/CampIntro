using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety => tip güvenliği
            //Do Not Repeat Yourself

            string categoryTag = "Kategori";
            int number = 32000;
            double interestRate = 1.45;
            bool isLogin = true;

            double dollarYesterday = 7.35;
            double dollarToday = 7.45;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Aazalış");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Değişmedi.");
            }

            if (isLogin == true)
            {
                Console.WriteLine("Kullanıcı Ayarları");
            }
            else
            {
                Console.WriteLine("Giriş yap");
            }


            Console.WriteLine(categoryTag);
        }
    }
}
