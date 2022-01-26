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
//You are given a folder in the file system
//(e. g. TestFolder). Calculate the size of all files in the folder and its subfolders.
//The result should be written to another text (e. g. оutput.txt) file in kilobytes.