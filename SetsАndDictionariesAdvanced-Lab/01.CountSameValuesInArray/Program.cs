using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> checker = new Dictionary<double, int>();
            foreach (double num in nums)
            {
                if (!checker.ContainsKey(num))
                {
                    checker.Add(num,1);
                }
                else
                {
                    checker[num]++;
                }
            }
            foreach (var num in checker)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
//Create a program that counts in a given array of double values the number of occurrences of each value. 