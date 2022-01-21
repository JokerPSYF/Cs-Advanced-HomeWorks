using System;
using System.Collections.Generic;

namespace _06.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            int names = int.Parse(Console.ReadLine());

            for (int i = 0; i < names; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", uniqueNames));
        }
    }
}
//Create a program, which will take a list of names and print only the unique names in the list.