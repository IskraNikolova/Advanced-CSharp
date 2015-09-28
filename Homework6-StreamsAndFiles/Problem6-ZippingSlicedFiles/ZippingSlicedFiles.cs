using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

public class ZippingSlicedFiles
{
    /// <summary>
    /// Modify your previous program to also compress the bytes while slicing parts and decompress them when 
    /// assembling them back to the original file. Use GzipStream.
    /// </summary>
    public static void Main()
    {
        string sourceFile = "../../ZippingSlicedFiles.cs";
        string destinationDirectory = "../../";
        int parts = int.Parse(Console.ReadLine());

        Slice(sourceFile, destinationDirectory, parts);
      
    }

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

            int partSize = bytes.Count/parts;
            int leftOver = bytes.Count - partSize*parts;
            for (int i = 0; i < parts; i++)
            {
                var newFile = destinationDirectory + "part-" + i + ".gz";
                using (var copy = new FileStream(newFile, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(copy, CompressionMode.Compress, false))
                    {
                        if (i == parts - 1)
                        {
                            compressionStream.Write(bytes.ToArray(), i * partSize, partSize + leftOver);
                        }
                        else
                        {
                            compressionStream.Write(bytes.ToArray(), i * partSize, partSize);
                        }
                    }
                 
                }
            }

        }

    }
}





