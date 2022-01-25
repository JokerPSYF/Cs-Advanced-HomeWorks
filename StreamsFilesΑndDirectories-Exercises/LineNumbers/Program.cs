using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            string inputPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string[] str = File.ReadAllLines(inputFilePath);
                int linesCount = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    linesCount = i + 1;
                    int lettersCount = 0;
                    int punctuationCount = 0;
                    for (int j = 0; j < str[i].Length; j++)
                    {
                        if (Char.IsLetter(str[i][j]))
                        {
                            lettersCount++;
                        }
                        else if (Char.IsPunctuation(str[i][j]))
                        {
                            punctuationCount++;
                        }
                    }

                    writer.WriteLine($"Line {linesCount}: {str[i]} ({lettersCount})({punctuationCount})");
                }
            }
        }
    }
}