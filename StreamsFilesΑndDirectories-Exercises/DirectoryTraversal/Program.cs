using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        public static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            StringBuilder builder = new StringBuilder();
            string[] filesPath = Directory.GetFiles(inputFolderPath, "*");
            var files = new Dictionary<string, Dictionary<string, decimal>>();

            foreach (string file in filesPath)
            {
                string fileName = Path.GetFileName(file);
                string extension = Path.GetExtension(file);
                decimal size = new FileInfo(file).Length / 1024.0m;

                if (!files.ContainsKey(extension))
                {
                    files.Add(extension, new Dictionary<string, decimal>());
                }
                files[extension].Add(fileName, size);
            }

            foreach (var fileKeyPair in files.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                builder.AppendLine(fileKeyPair.Key);
                foreach (var item in fileKeyPair.Value.OrderBy(x => x.Value))
                {
                    builder.AppendLine($"--{item.Key} - {item.Value}kb");
                }
            }
            return builder.ToString().Trim();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(path, textContent);
        }

    }
}