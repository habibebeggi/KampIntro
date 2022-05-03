using System;
namespace Loops
{
    class Program
    {
        static void Main(string[]args)
        {
            string course1 = "Software Developer Training Camp ";
            string course2 = "Basic Course For Introduction To Programming";
            string course3 = "Java Programming";
            string course4 = "Python for Machine Learning";
            string course5 = "System Programming With C++";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine(course5);

            //Array
            string[] courses = new string[] { course1, "Basic Course For Introduction To Programming", "Java Programming",course4, "OOP With C#"};
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("Loop finished! ");
            
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Footer");
        }
    }
}