using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> sumOfName = (s, i) => { return s.Sum(x => x) >= i; };

            Func<Func<string, int, bool>, string[], string> checker = (func, arr) =>
            {
                return arr.Where(x => func(x, num)).FirstOrDefault();
            };

            Console.WriteLine(checker(sumOfName, names));
        }
    }
}
//Create a program that traverses a collection of names and returns the first name,
//whose sum of characters is equal to or larger than a given number N,
//which will be given on the first line.
//Use a function that accepts another function as one of its parameters.
//Start by building a regular function to hold the basic logic of the program.
//Something along the lines of Func<string, int, bool>.
//Afterward, create your main function which should accept the first function as one of its parameters.