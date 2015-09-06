using System;

public class UnicodeCharacters
{
    /// <summary>
    /// A program that converts a string to a sequence of C# Unicode character literals.
    /// </summary>
    public static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            int character = (int)input[i];
            Console.Write("\\u00{0:X}", character);
        }
        Console.WriteLine();
    }
}

