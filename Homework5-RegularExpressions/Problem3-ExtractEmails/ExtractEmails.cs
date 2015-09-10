using System;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"\b(\w+.)?\w+@\w+.\w+.\w+\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

