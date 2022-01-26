using System.IO.Compression;

namespace ZipAndExtract
{
    using System;
    using System.IO;
    public class ZipAndExtract
    {
        public static void Main(string[] args)
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using ZipArchive zipFile = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);

            zipFile.CreateEntryFromFile(inputFilePath, "copyMe.png");
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using ZipArchive zipArchive = ZipFile.OpenRead(zipArchiveFilePath);

            var zip = zipArchive.GetEntry(fileName);

            zip.ExtractToFile(outputFilePath);
        }
    }
}
//Write a program that creates a ZIP file (archive),
//holding a given input file, and extracts the ZIP-ed file from the archive into in separate output file.
//    Use the copyMe.png file from your resources as input and zip it into a ZIP file of your choice, e. g. archive.zip.
//    Extract the file from the archive into a new file of your choice, e. g. extracted.png.