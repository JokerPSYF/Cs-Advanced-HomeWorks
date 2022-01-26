using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        public static void Main(string[] args)
        {
            string firstInputFilePath = @"..\..\..\input1.txt";
            string secondInputFilePath = @"..\..\..\input2.txt";
            string outputFilePath = @"..\..\..\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string[] first = File.ReadAllLines(firstInputFilePath);
                string[] second = File.ReadAllLines(secondInputFilePath);

                if (first.Length >= second.Length)
                {
                    for (int i = 0; i < first.Length; i++)
                    {
                        writer.WriteLine(first[i]);
                        if (i < second.Length)
                        {
                            writer.WriteLine(second[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < second.Length; i++)
                    {
                        if (i < first.Length)
                        {
                            writer.WriteLine(first[i]);
                        }
                        writer.WriteLine(second[i]);
                    }
                }
            }
        }
    }
}
//Write a program that reads the contents of two input text files
//(e. g. input1.txt and input2.txt) and merges them line by line together into a third text file
//(e. g. output.txt). The merging is done as follows:
//    Line 1 from input1.txt
//    Line 1 from input2.txt
//    Line 2 from input1.txt
//    Line 2 from input2.txt
//    …
//If some of the files have more lines than the other,
//append at the end of the output the lines, which cannot be matched with the other file.