using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> checker = name => { return name.Length <= num; };

            Console.WriteLine(string.Join("\n", names.Where(name => checker(name))));
        }
    }
}
//Write a program that filters a list of names according to their length.
//On the first line, you will be given an integer n, representing a name's length.
//On the second line, you will be given some names as strings separated by space.
//Write a function that prints only the names whose length is less than or equal to n.