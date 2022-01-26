using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        public static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder builder = new StringBuilder();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        line = ReplaceSymbols(line);
                        line = ReverseWords(line);

                        builder.AppendLine(line);
                    }

                    counter++;
                    line = reader.ReadLine();
                }

                return builder.ToString().Trim();
            }
        }
        public static string ReverseWords(string replacedSymbols)
        {
            replacedSymbols = string.Join(" ", replacedSymbols.Split().Reverse());
            return replacedSymbols;
        }

        public static string ReplaceSymbols(string line)
        {
            char[] symbols = new[] { '-', ',', '.', '!', '?' };
            foreach (char symbol in symbols)
            {
                line = line.Replace(symbol, '@');
            }

            return line;
        }
    }
}
//Write a program that reads a text file (e. g. text.txt) and prints on the console its even lines.
//Line numbers start from 0. Use StreamReader.
//Before you print the result, replace {"-", ",", ".", "!", "?"} with "@" and reverse the order of the words.