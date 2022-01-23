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
