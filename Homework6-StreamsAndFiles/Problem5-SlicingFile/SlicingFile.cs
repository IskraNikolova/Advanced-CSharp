using System;
using System.Collections.Generic;
using System.IO;

public class SlicingFile
{
    //Write a program that takes any file and slices it to n parts. Write the following methods:
    public static void Main()
    {
        string sourceFile = "../../SlicingFile.cs";
        string destinationDirectory = "../../";
        int parts = int.Parse(Console.ReadLine());

        Slice(sourceFile, destinationDirectory, parts);
        Assemble(new List<string>() { }, "../../Constructed.txt");
    }
    //Slice(string sourceFile, string destinationDirectory, int parts) - slices the given source file into n parts and 
    //saves them in destinationDirectory.
    public static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            byte[] buffer = new byte[4096];
            List<byte> bytes = new List<byte>();
            while (true)
            {
                int readBytes = source.Read(buffer, 0, buffer.Length);
                if (readBytes == 0)
                {
                    break;
                }

                for (int i = 0; i < readBytes; i++)
                {
                    bytes.Add(buffer[i]);
                }
            }

            int partSize = bytes.Count / parts;
            int leftOver = bytes.Count - partSize * parts;
            for (int i = 0; i < parts; i++)
            {
                var newFile = destinationDirectory + "part-" + i + ".txt";
                using (var copy = new FileStream(newFile, FileMode.Create))
                {
                    if (i == parts - 1)
                    {
                        copy.Write(bytes.ToArray(), i * partSize, partSize + leftOver);
                    }
                    else
                    {
                        copy.Write(bytes.ToArray(), i * partSize, partSize);
                    }
                }
            }

        }

    }
    //Assemble(List<string> files, string destinationDirectory) - combines all files into one, in the order they are passed, 
    //and saves the result in destinationDirectory.
    public static void Assemble(List<string> files, string destinationDirectory)
    {
        var bytes = new List<byte>();
        for (int i = 0; i < files.Count; i++)
        {
            var sourceFile = files[i];
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    for (int j = 0; j < readBytes; j++)
                    {
                        bytes.Add(buffer[j]);
                    }
                }
            }
        }

        using (var copy = new FileStream(destinationDirectory, FileMode.Create))
        {
            copy.Write(bytes.ToArray(), 0, bytes.Count);
        }

    }

}

