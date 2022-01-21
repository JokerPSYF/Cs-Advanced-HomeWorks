using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> elements = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (string element in input)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
        }
    }
}
