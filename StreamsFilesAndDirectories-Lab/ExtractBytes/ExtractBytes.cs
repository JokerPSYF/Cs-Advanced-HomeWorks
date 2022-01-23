using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExtractBytes
{
    public class ExtractBytes
    {
        public static void Main(string[] args)
        {
            string binaryFilePath = @"..\..\..\example.png";
            string bytesFilePath = @"..\..\..\bytes.txt";
            string outputPath = @"..\..\..\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using StreamReader reader = new StreamReader(bytesFilePath);
            byte[] bytes = File.ReadAllBytes(binaryFilePath);
            List<string> neededBytes = new List<string>();
            StringBuilder builder = new StringBuilder();
            string line = reader.ReadLine();

            while (line != null)
            {
                neededBytes.Add(line);
                line = reader.ReadLine();
            }

            foreach (var byter in bytes)
            {
                if (neededBytes.Contains(byter.ToString()))
                {
                    builder.Append(byter.ToString());
                }
            }

            using StreamWriter writer = new StreamWriter(outputPath);
            writer.WriteLine(builder.ToString().Trim());
        }
    }
}
