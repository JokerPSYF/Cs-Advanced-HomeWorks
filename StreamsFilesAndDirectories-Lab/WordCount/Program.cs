using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        public static void Main(string[] args)
        {
            string wordsFilePath = @"..\..\..\words.txt";
            string textFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();

            string[] words = File.ReadAllLines(wordsFilePath);
            string[] word = words[0].ToLower().Split();
            string[] text = File.ReadAllLines(textFilePath);

            for (int i = 0; i < word.Length; i++)
            {
                counter.Add(word[i].ToLower(), 0);
                for (int j = 0; j < text.Length; j++)
                {
                    string[] currLine = text[j]
                        .ToLower()
                        .Split(new char[] { '-', '.', ' ', ',', '!', '?' }
                            , StringSplitOptions.RemoveEmptyEntries);
                    for (int k = 0; k < currLine.Length; k++)
                    {
                        if (word[i] == currLine[k])
                        {
                            counter[word[i]]++;
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var pair in counter.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{pair.Key} - {pair.Value}");
                }
            }
        }
    }
}
