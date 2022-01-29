using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> giveMin = n => n.Min();

            Console.WriteLine(giveMin(nums));
        }
    }
}
//Create a simple program that reads from the
//console a set of integers and prints back on the console the smallest number from the collection. Use Func<T, T>.
