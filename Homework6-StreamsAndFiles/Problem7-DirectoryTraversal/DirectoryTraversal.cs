using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


public class DirectoryTraversal
{
    public static void Main()
    {
        FileInfo fileInfo = new FileInfo("../../temp.txt");
        DirectoryInfo directoryInfo = fileInfo.Directory;
        FileSystemInfo[] fsi = directoryInfo.GetFileSystemInfos();

        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach (FileSystemInfo info in fsi)
        {
            var name = info.Name;
            string regex = @"(.*(\..*))";
            if (Regex.IsMatch(name, regex))
            {
                var match = Regex.Match(name, regex);
                if (!result.ContainsKey(match.Groups[2].ToString()))
                {
                    result.Add(match.Groups[2].ToString(), new List<string>());
                }

                result[match.Groups[2].ToString()].Add(match.Groups[1].ToString());
            }
        }

        var sortedResults = result.OrderByDescending(files => files.Value.Count).ThenBy(files => files.Key);

        try
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (var writer = new StreamWriter(desktop))
            {
                foreach (var extencion in sortedResults)
                {
                    writer.WriteLine(extencion.Key);
                    extencion.Value.Reverse();
                    foreach (var file in extencion.Value)
                    {
                        writer.WriteLine("--{0}", file);
                    }
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            foreach (var extencion in sortedResults)
            {
                Console.WriteLine(extencion.Key);
                extencion.Value.Sort();
                foreach (var file in extencion.Value)
                {
                    Console.WriteLine("--{0}", file);
                }
            }
        }
    }
}

