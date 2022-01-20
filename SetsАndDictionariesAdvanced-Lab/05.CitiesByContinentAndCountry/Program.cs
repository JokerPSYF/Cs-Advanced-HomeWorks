using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dictionary =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!dictionary.ContainsKey(continent))
                {
                    dictionary.Add(continent, new Dictionary<string, List<string>>());
                    dictionary[continent].Add(country, new List<string>());
                    dictionary[continent][country].Add(city);
                }
                else if (dictionary[continent].ContainsKey(country))
                {
                    dictionary[continent][country].Add(city);
                }
                else 
                {
                    dictionary[continent].Add(country, new List<string>());
                    dictionary[continent][country].Add(city);
                }
            }
            foreach (var continent in dictionary)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
//Create a program that reads continents, countries, and their cities put them in a nested dictionary and prints them.