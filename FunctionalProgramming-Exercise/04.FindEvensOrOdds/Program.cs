using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fromTonums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = fromTonums[0];
            int end = fromTonums[1];

            string EvenOdd = Console.ReadLine();

            List<int> nums = Enumerable.Range(start, end - start + 1).ToList();

            Predicate<int> predicate = num =>
            {
                if (EvenOdd == "odd")
                {
                    return num % 2 != 0;
                }
                else
                {
                    return num % 2 == 0;
                }
            };

            foreach (var num in nums)
            {
                if (predicate(num))
                {
                    Console.Write(num + " ");
                }
            }

        }
    }
}
//You are given a lower and an upper bound for a range of integer numbers.
//Then a command specifies if you need to list all even or odd numbers in the given range. Use Predicate<T>.