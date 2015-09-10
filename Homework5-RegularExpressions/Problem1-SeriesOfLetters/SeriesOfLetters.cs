using System;
using System.Text.RegularExpressions;

public class SeriesOfLetters
{
    /// <summary>
    /// Aprogram that reads a string from the console and replaces all series of consecutive identical letters with a single one.
    /// </summary>
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"([a-zA-Z])\1{0,}";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.Write(match.Groups[1]);
        }
        Console.WriteLine();
    }
}

