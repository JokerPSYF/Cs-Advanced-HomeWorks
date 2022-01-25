using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main(string[] args)
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

                return builder.ToString();
            }
        }
        private static string ReverseWords(string replacedSymbols)
        {
            replacedSymbols = string.Join(" ", replacedSymbols.Split().Reverse());
            return replacedSymbols;
        }

        private static string ReplaceSymbols(string line)
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