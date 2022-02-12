﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> customComparator = (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }

                return x.CompareTo(y);
            };

                Array.Sort(list, (x, y) => customComparator(x, y));

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
