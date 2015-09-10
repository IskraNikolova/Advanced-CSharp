using System;
using System.Text.RegularExpressions;

public class SentenceExtractor
{
    /// <summary>
    /// A program that reads a keyword and some text from the console and prints all sentences from the text,
    ///  containing that word. A sentence is any sequence of words ending with '.', '!' or '?'.
    /// </summary>
    public static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = @"([A-Z][\w\W]*?\b"+ word + @"\b[\w\W]*?[.!?])";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

