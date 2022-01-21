using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]]++;
                }
                else
                {
                    dictionary.Add(input[i], 1);
                }
            }

            foreach (var ch in dictionary)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
//Create a program that reads some text from the console and counts the occurrences of each character in it.
//Print the results in alphabetical (lexicographical) order. 