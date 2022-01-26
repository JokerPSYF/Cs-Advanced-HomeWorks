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
//Write a program that reads a text file (e. g. text.txt)
//and inserts line numbers in front of each of its lines and count all the letters and punctuation marks.
//The result should be written to another text file (e. g. output.txt).
//Use the static class File to read and write all the lines of the input and output files.