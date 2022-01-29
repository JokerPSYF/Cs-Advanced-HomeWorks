using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var nums = Enumerable.Range(1, range); 

            Dictionary<int,Predicate<int>> predicates = new Dictionary<int, Predicate<int>>();

            foreach (int divider in dividers)
            {
                if (!predicates.ContainsKey(divider))
                {
                    Predicate<int> divide = x =>
                    {
                        return x % divider == 0;
                    };

                    predicates.Add(divider, divide);
                }
            }

            foreach (int num in nums)
            {
                bool isdivide = true;

                foreach (Predicate<int> predicate in predicates.Values)
                {
                    if (!predicate(num))
                    {
                        isdivide = false;
                    }
                }

                if (isdivide)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
//Find all numbers in the range 1...N that is divisible by the numbers of a given sequence.
//On the first line, you will be given an integer N – which is the end of the range.
//On the second line, you will be given a sequence of integers which are the dividers.
//Use predicates/functions.