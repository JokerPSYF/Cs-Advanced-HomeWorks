using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string cloth in clothes)
                {
                    if (wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth]++;
                    }
                    else
                    {
                        wardrobe[color].Add(cloth, 1);
                    }
                }
            }

            string[] searchedCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var pair in wardrobe)
            {
                Console.WriteLine($"{pair.Key} clothes:");
                foreach (var clothes in pair.Value)
                {
                    if (searchedCloth[0] == pair.Key && searchedCloth[1] == clothes.Key)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }
        }
    }
}