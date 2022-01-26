using System.Collections.Generic;
using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        public static void Main(string[] args)
        {
            string inputPath = @"..\..\..\copyMe.png";
            string outputPath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputPath, outputPath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Open, FileAccess.Write))
                {
                    byte[] bytes = new byte[reader.Length];
                    int bufer = reader.Read(bytes, 0, (int)reader.Length);
                    writer.Write(bytes, 0, bufer);
                }
            }
        }
    }
}
//Write a program that copies the contents of a binary file (e. g. copyMe.png)
//to another binary file (e. g. copyMe-copy.png) using FileStream.You are not
//allowed to use the File class or similar helper classes.