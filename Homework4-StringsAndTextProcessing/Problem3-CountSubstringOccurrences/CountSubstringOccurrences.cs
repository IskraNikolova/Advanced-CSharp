﻿using System;

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
        int diff = searchSubstring.Length - 1;

        int count = 0;
        for (int i = 0; i < input.Length - diff; i++)
        {
            string substringForCheck = input.Substring(i, searchSubstring.Length);
            if (searchSubstring == substringForCheck)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
