using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(SortedStringWithOnlyEvens(array));
        }

        private static string SortedStringWithOnlyEvens(int[] array)
        {
            List<int> sortedList = new List<int>(array.OrderBy(x => x).Where(x => x % 2 == 0));

            string sortedEvenNumbers = string.Join(", ", sortedList);
            return sortedEvenNumbers;
        }
    }
}
//Create a program that reads one line of integers separated by ", ".
//Then prints the even numbers of that sequence sorted in increasing order.
