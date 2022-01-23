using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string wordsFilePath = @"../../../words.txt";
            string textFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            Dictionary<string, int> finalDic = CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in finalDic.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }

        public static Dictionary<string, int> CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader(wordsFilePath))
            {

                string[] strArray = wordsReader.ReadLine().Split();

                using (StreamReader textReader = new StreamReader(textFilePath))
                {
                    StreamWriter writer = new StreamWriter(outputFilePath);


                    string[] line = textReader.ReadLine()
                        .ToLower()
                        .Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' });

                    while (line != null)
                    {
                        foreach (string word in strArray)
                        {
                            foreach (string item in line)
                            {
                                if (word == item && words.ContainsKey(word))
                                {
                                    words[word]++;
                                }
                                else if (word == item && !words.ContainsKey(word))
                                {
                                    words.Add(word, 1);
                                }
                            }
                        }

                        line = textReader.ReadLine()
                            .ToLower()
                            .Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' });
                    }
                }
            }
            return words;
        }
    }
}
