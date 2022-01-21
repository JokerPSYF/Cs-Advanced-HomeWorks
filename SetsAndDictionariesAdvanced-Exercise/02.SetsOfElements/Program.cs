using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            int[] NandM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < NandM[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < NandM[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            firstSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
//Create a program that prints a set of elements. On the first line,
//you will receive two numbers - n and m,
//which represent the lengths of two separate sets. On the next n + m lines,
//you will receive n numbers, which are the numbers in the first set, and m numbers,
//which are in the second set.
//Find all the unique elements that appear in both of them and print
//them in the order in which they appear in the first set - n.