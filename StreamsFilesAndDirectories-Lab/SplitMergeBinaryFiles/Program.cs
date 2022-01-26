//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace SplitMergeBinaryFiles
//{
//    public class SplitMergeBinaryFile
//    {
//        public static void Main(string[] args)
//        {
//            string sourceFilePath = @"..\..\..\example.png";
//            string partOneFilePath = @"..\..\..\part-1.bin";
//            string partTwoFilePath = @"..\..\..\part-2.bin";
//            string joinedFilePath = @"..\..\..\example-joined.png";

//            SplitBinaryFile(sourceFilePath, partOneFilePath, partTwoFilePath);
//            MergeBinaryFiles(partOneFilePath, partTwoFilePath, joinedFilePath);
//        }

//        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
//        {
//            using FileStream fileReader = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read);

//            byte[] bytes = File.ReadAllBytes(sourceFilePath);
//            long allBytes = fileReader.Length;
//            long firstBytes = (long)Math.Ceiling(allBytes / 2.0);
//            long secondBytes = allBytes - firstBytes;

//            byte[] buffer1 = new byte[firstBytes];
//            byte[] buffer2 = new byte[secondBytes];

//            int bytes1 = fileReader.Read(buffer1, 0, buffer1.Length);
//            int bytes2 = fileReader.Read(buffer2, 0, buffer2.Length);
//            fileReader.Close();

//            using FileStream writer1 = new FileStream(partOneFilePath, FileMode.OpenOrCreate, FileAccess.Write);
//            writer1.Write(buffer1, 0, bytes1);
//            writer1.Close();

//            using FileStream writer2 = new FileStream(partTwoFilePath, FileMode.OpenOrCreate, FileAccess.Read);
//            writer2.Write(buffer2, 0, bytes2);
//            writer2.Close();
//        }

//        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
//        {
//           using FileStream fileStreamReadr1 = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read);
//              byte[] newBuffer1 = new byte[fileStreamReadr1.Length];
//              int bytes3 = fileStreamReadr1.Read(newBuffer1, 0, newBuffer1.Length);
//                  fileStreamReadr1.Close();

//             using FileStream fileStreamReadr2 = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read);
//              byte[] newBuffer2 = new byte[fileStreamReadr2.Length];
//              int bytes4 = fileStreamReadr2.Read(newBuffer2, 0, newBuffer2.Length);
//              fileStreamReadr2.Close();


//                  using FileStream fileStreamWriterJoinedPng = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write);
//              fileStreamWriterJoinedPng.Write(newBuffer1, 0, bytes3);
//              fileStreamWriterJoinedPng.Write(newBuffer2, 0, bytes4);
//                  fileStreamWriterJoinedPng.Close();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        public static void Main(string[] args)
        {
            string sourceFilePath = @"..\..\..\example.png";
            string partOneFilePath = @"..\..\..\part-1.bin";
            string partTwoFilePath = @"..\..\..\part-2.bin";
            string joinedFilePath = @"..\..\..\example-joined.png";

            SplitBinaryFile(sourceFilePath, partOneFilePath, partTwoFilePath);
            MergeBinaryFiles(partOneFilePath, partTwoFilePath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] bytes = File.ReadAllBytes(sourceFilePath);

            List<string> firstPart = new List<string>();
            List<string> secondPart = new List<string>();

            if (bytes.Length % 2 == 0)
            {
                for (int i = 0; i < bytes.Length / 2; i++)
                {
                    firstPart.Add(bytes[i].ToString());
                }

                for (int j = bytes.Length / 2; j < bytes.Length; j++)
                {
                    secondPart.Add(bytes[j].ToString());
                }
            }
            else
            {
                for (int i = 0; i < bytes.Length / 2 + 1; i++)
                {
                    firstPart.Add(bytes[i].ToString());
                }

                for (int j = bytes.Length / 2 + 1; j < bytes.Length; j++)
                {
                    secondPart.Add(bytes[j].ToString());
                }
            }

            using StreamWriter writer1 = new StreamWriter(partOneFilePath);
            foreach (string byter in firstPart)
            {
                writer1.Write(byter + " ");
            }
            writer1.Close();


            using StreamWriter writer2 = new StreamWriter(partTwoFilePath);
            foreach (string byter in secondPart)
            {
                writer2.Write(byter + " ");
            }
            writer2.Close();

        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using StreamReader reader1 = new StreamReader(partOneFilePath);
            reader1.ReadToEnd();
            reader1.Close();

            using StreamReader reader2 = new StreamReader(partTwoFilePath);
            reader2.ReadToEnd();
            reader2.Close();

            using StreamWriter writer1 = new StreamWriter(joinedFilePath);
            writer1.WriteLine(reader1);
            writer1.WriteLine(reader2);
            writer1.Close();
        }
    }
}
//You are given an input binary file (e. g. example.png).
//Write a program to split it into two equal-sized files
//(e. g. part-1.bin and part-2.bin). When the input file size is an odd number,
//the first part should be 1 byte bigger than the second.
//    After splitting the input file, join the obtained files into a new file
// (e.g.example - joined.png).The obtained result file should be the same as the initial input file.