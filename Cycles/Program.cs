using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Yazılım Geliştirme";
            string course2 = "Programlamaya Giriş";
            string course3 = "Java";
            string course4 = "Python";
            string course5 = "C#";
            string course6 = "C++";

            //Array => Dizi
            string[] courses = new string[] { "Yazılım Geliştirme", "Programlamaya Giriş", "Java", "Python", "C#", "C++" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For Cycle Sonu");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            
            Console.WriteLine("Sayfa Sonu => Footer");

        }
    }
}
