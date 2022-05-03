using System;

namespace ValueAndReferenceTypes
{
    class program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            //value type
            num1 = num2;
            num2 = 45;
            Console.WriteLine(num1);

            //reference types
            //Arrays, class, string, object, interface is reference types.
            int[] numbers1 = new int[] { 10, 15, 25 };
            int[] numbers2= new int[] { 45, 55, 65 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);
        }
    }
}