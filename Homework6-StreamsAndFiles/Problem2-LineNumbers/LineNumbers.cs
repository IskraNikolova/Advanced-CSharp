using System.IO;

public class LineNumbers
{
    /// <summary>
    /// A program that reads a text file and inserts line numbers in front of each of its lines. 
    /// The result should be written to another text file. Use StreamReader in combination with StreamWriter.
    /// </summary>
    public static void Main()
    {
        StreamReader reader = new StreamReader("Text.txt");
        StreamWriter writer = new StreamWriter("Copy.txt");

        using (reader)
        {
            using (writer)
            {
                int lineNumber = 1;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    writer.WriteLine($"{lineNumber}. {line}");
                    lineNumber++;
                }
            }
        }
    }
}

