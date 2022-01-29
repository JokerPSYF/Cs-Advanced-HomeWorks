using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int devider = int.Parse(Console.ReadLine());

            Predicate<int> divide = nums =>
            {
                return nums % devider != 0;
            };

            nums.Reverse();

            Console.WriteLine(string.Join(" ", nums.Where(x => divide(x))));

        }
    }
}
//Create a program that reverses a collection and
//removes elements that are divisible by a given integer n. Use predicates/functions.