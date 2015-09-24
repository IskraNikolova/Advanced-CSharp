using System;

public class UnicodeCharacters
{
    /// <summary>
    /// A program that converts a string to a sequence of C# Unicode character literals.
    /// </summary>
    public static void Main()
    {
        string input = Console.ReadLine();
        foreach (char character in input)
        {
            Console.Write("\\u00{0:X}", (ushort)character);
        }
        Console.WriteLine();
    }
}

