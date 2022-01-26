using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<decimal[]> action = AddVAT;

            decimal[] array = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            action(array);

            foreach (decimal num in array)
            {
                Console.WriteLine($"{num:f2}");
            }
        }

        private static void AddVAT(decimal[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] *= 1.20m;
            }
        }
    }
}
//Create a program that reads one line of double prices separated by ", ".
//Print the prices with added VAT for all of them. Format them to 2 signs after the decimal point.
//The order of the prices must be the same.
//    VAT is equal to 20% of the price.