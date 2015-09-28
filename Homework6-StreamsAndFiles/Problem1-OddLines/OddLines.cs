using System;
using System.IO;

public class OddLines
{
    /// <summary>
    /// A program that reads a text file and prints on the console its odd lines. Line numbers starts from 0. Use StreamReader.
    /// </summary>
    public static void Main()
    {
        using (var reader = new StreamReader("Text.txt"))
        {
            int lineNumber = 0;

            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber%2 != 0)
                {

                    Console.WriteLine($"{lineNumber}: {line}");
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }
}

