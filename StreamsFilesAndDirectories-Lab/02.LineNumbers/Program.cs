using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();
                StreamWriter writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
//Write a program that reads a text file (e. g. input.txt)
//and inserts line numbers in front of each of its lines.
//The result should be written to another text file (e. g. output.txt). Use StreamReader and StreamWriter.