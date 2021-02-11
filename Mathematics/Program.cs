using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            //3+5 sonucu ekrana yazdırılır
            operations.Summation(3, 5);

            operations.Summation(5, 8);
        }
    }
}
