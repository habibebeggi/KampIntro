using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Emel");

            Console.WriteLine(names.Length);

            names.Add("Kubilay");

            Console.WriteLine(names.Length);

            foreach (string name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}