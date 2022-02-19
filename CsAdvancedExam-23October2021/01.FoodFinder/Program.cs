using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //"pear"
            //    "flour"
            //    "pork"
            //    "olive"

            List<char> pear = new List<char>() { 'p', 'e', 'a', 'r' };
            List<char> flour = new List<char>() { 'f', 'l', 'o', 'u', 'r' };
            List<char> pork = new List<char>() { 'p', 'o', 'r', 'k' };
            List<char> olive = new List<char>() { 'o', 'l', 'i', 'v', 'e' };

            int words = 0;
            List<string> collectedWord = new List<string>();

            Queue<char> vowels = new Queue<char>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse));

            Stack<char> consonants = new Stack<char>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray());

            while (consonants.Any())
            {
                char vowel = vowels.Dequeue();
                char consonant = consonants.Pop();

                if (pear.Contains(vowel)) pear.Remove(vowel);

                if (pear.Contains(consonant)) pear.Remove(consonant);

                if (flour.Contains(vowel)) flour.Remove(vowel);

                if (flour.Contains(consonant)) flour.Remove(consonant);

                if (pork.Contains(vowel)) pork.Remove(vowel);

                if (pork.Contains(consonant)) pork.Remove(consonant);

                if (olive.Contains(vowel)) olive.Remove(vowel);

                if (olive.Contains(consonant)) olive.Remove(consonant);

                

                vowels.Enqueue(vowel);
            }
            
            if (pear.Count == 0) { collectedWord.Add("pear"); words++; }

            if (flour.Count == 0)
            {
                collectedWord.Add("flour");
                words++;
            }

            if (pork.Count == 0)
            {
                collectedWord.Add("pork");
                words++;
            }

            if (olive.Count == 0)
            {
                collectedWord.Add("olive");
                words++;
            }

            Console.WriteLine($"Words found: {words}");
            Console.WriteLine(string.Join(Environment.NewLine, collectedWord));
        }
    }
}
