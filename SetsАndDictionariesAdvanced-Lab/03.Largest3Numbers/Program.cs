using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list = new List<int>(list.OrderByDescending(x => x).Take(3));
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
//Read a list of integers and print the largest 3 of them. If there are less than 3, print all of them