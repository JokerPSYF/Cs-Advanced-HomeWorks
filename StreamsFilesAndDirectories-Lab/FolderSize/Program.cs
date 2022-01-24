using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        public static void Main(string[] args)
        {
            string folderPath = @"../../../TestFolder";
            string outputFilePath = @"../../../output.txt";

            GetFolderSize(folderPath, outputFilePath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] fileInfos = dir.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fileInfo in fileInfos)
            {
                sum += fileInfo.Length;
            }

            sum /= 1024;

            File.WriteAllText(outputFilePath, sum.ToString() + " KB");
        }
    }
}
