using System;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    /// <summary>
    /// A program that replaces in a HTML document given as string all the tags <a href=…>…</a> 
    /// with corresponding tags [URL href=…]…[/URL]. Print the result on the console.
    /// </summary>
    public static void Main()
    {
        //Note: The input may be read on a single line (unlike the example above) or from a file.
        //Remove all new lines if you choose the first approach.

        string input = "<ul> <li> <a href = http://softuni.bg>SoftUni </a> </li> </ul>";

        string[] patterns = new[] {@"(<a)", @"(>)(?=\w)", @"(</a>)"};
        string[] replacements = new[] {"[URL", "]", "[/URL]"};
        string result = input;

        for (int i = 0; i < patterns.Length; i++)
        {
            Regex regex = new Regex(patterns[i]);
            string replace = replacements[i];
            result = regex.Replace(result, replace);

        }
        Console.WriteLine(result);
    }
}

