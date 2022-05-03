using System;
namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety, do not repeat yourself, alias
            string categoryTag = "Categories";
            int studentNumber = 3700;
            double interestRate = 1.45;
            bool IsLogin = true;
            double dollarInYesterday = 12.25;
            double dollarInToday = 15.65;

            if (dollarInYesterday > dollarInToday)
            {
                Console.WriteLine("Decrease button");
            }
            else if(dollarInYesterday < dollarInToday)
            {
                Console.WriteLine("Increase button");
            }
            else
            {
                Console.WriteLine("No change button");
            }
            if (IsLogin == true)
            {
                Console.WriteLine("User settings button");
            }
            else
            {
                Console.WriteLine("Login button");
            }
            Console.WriteLine(categoryTag);
        }
    }
}