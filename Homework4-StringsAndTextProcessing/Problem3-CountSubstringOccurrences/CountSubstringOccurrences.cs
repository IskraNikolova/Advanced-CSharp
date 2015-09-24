using System;

public class CountSubstringOccurrences
{
    /// <summary>
    /// A program to find how many times a given string appears in a given text as substring.
    /// </summary>
    public static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToLower();

        string searchSubstring = Console.ReadLine();

        Console.WriteLine(CountOfEqualsSubstring(input, searchSubstring));
    }

    static int CountOfEqualsSubstring(string inputText, string searchString)
    {
        int diff = searchString.Length - 1;

        int count = 0;
        for (int i = 0; i < inputText.Length - diff; i++)
        {
            string substringForCheck = inputText.Substring(i, searchString.Length);
            if (searchString == substringForCheck)
            {
                count++;
            }
        }
        return count;
    }
}

