using System;
using System.Linq;
using System.Text;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parser = n => int.Parse(n);
            int[] array = input
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(GiveCountAndSum(array));
        }

        private static string GiveCountAndSum(int[] array)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(array.Length.ToString());
            builder.AppendLine(array.Sum().ToString());
            return builder.ToString();
        }
    }
}
//Create a program that reads a line of integers separated by ", ".
//Print on two lines the count of numbers and their sum.