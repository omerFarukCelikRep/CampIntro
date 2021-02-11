using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Teacher = "Engin Demiroğ";
            course1.Rating = 80;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Teacher = "Kerem Varış";
            course2.Rating = 65;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Teacher = "Berkay Bilgin";
            course3.Rating = 90;

            Course course4 = new Course();
            course4.CourseName = "C++";
            course4.Teacher = "Murat Kurtboğan";
            course4.Rating = 95;

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Teacher);
            }
        }
    }
}
