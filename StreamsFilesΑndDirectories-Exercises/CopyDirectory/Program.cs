﻿using System.IO;

namespace CopyDirectory
{
    using System;
    public class CopyDirectory
    {
        static void Main(string[] args)
        {
            string inputPath = Console.ReadLine();
            string outputPath = Console.ReadLine();

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            string[] files = Directory.GetFiles(inputPath);

            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }
            else
            {
                Directory.CreateDirectory(outputPath);
            }

            foreach (string file in files)
            {
                string fileName = outputPath + "\\" + Path.GetFileName(file);
                File.Copy(file, fileName);
            }
        }
    }
}