using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num]++;
                }
                else
                {
                    dictionary.Add(num, 1);
                }
            }

            foreach (var num in dictionary)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                    return;
                }
            }
        }
    }
}
//Create a program that prints a number from a collection,
//which appears an even number of times in it.
//On the first line, you will be given n – the count of integers you will receive.
//On the next n lines, you will be receiving the numbers.
//It is guaranteed that only one of them appears an even number of times.
//Your task is to find that number and print it in the end. 