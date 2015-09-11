using System;
using System.Text;
using System.Text.RegularExpressions;

public class ExtractHyperlinks
{
    public static void Main()
    {
        StringBuilder text = new StringBuilder();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            text.Append(input);
        
        }
        string textToString = text.ToString();
        string pattern = @"<a.*?(?<!>)href\s*?=\s*([""'])?(.*?)(?=(?<=\s)\w+=|>|\1)";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(textToString);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[2].ToString().Trim());
        }

        //check this solution in Softuni Judge 100/100
    }
}

