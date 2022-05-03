using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ayşe";
            int yas = 25;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Büşra A";
            course1.Rating = 100;

            Course course2 = new Course();
            course2.CourseName = "Python";
            course2.Instructor = "Engin D";
            course2.Rating = 80;

            Course course3 = new Course();
            course3.CourseName = "Java";
            course3.Instructor = "Berkay B";
            course3.Rating = 95;

            //Console.WriteLine(course1.CourseName+ " : " +course1.Instructor );
            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine("Course Name: "+ course.CourseName + "\n Course Instructor:  " + course.Instructor + "\n Course Rating: "+course.Rating);
            }
        }
    }
    class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int Rating { get; set; }
    }
}

