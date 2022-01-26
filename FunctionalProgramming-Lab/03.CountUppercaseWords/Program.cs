using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> uppercaseWordOnly = n => n[0] == n.ToUpper()[0];

            string[] uppers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(n => uppercaseWordOnly(n)).ToArray();

            foreach (string str in uppers)
            {
                Console.WriteLine(str);
            }

        }
    }
}
//Create a program that reads a line of text from the console.
//Print all the words that start with an uppercase letter in the same order you've received them in the text