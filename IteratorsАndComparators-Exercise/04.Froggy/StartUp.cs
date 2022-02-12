using System;
using System.Linq;

namespace _04.Froggy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Lake myLake = new Lake(arr);

            Console.WriteLine(string.Join(", ", myLake));
        }
    }
}
