using System;
using System.Text;
using System.Text.RegularExpressions;

public class UseYourChainsBuddy
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @".*?(<p>)(.*?)(<\/p>).*?";

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        StringBuilder result = new StringBuilder();
        foreach (Match match in matches)
        {
            result.Append(match.Groups[2]);
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsUpper(result[i]) ||
                !char.IsLetter(result[i]) &&
                !char.IsDigit(result[i]))
            {
                result[i] = ' ';
            }
        }


        string value = ChangeLetters(result);
        string patternForWhiteSpace = @"(\s{2,})";
        string replaceWhiteSpce = " ";
        Regex regexForReplace = new Regex(patternForWhiteSpace);
        string rezultValue = regexForReplace.Replace(value, replaceWhiteSpce);
        Console.WriteLine(rezultValue);
    }

    private static string ChangeLetters(StringBuilder builder)
    {
        for (int i = 0; i < builder.Length; i++)
        {
            if (builder[i] <= 109 && builder[i] != ' ' && !char.IsDigit(builder[i]))
            {
                builder[i] += (char)(13);
            }
            else if (builder[i] >= 109 && builder[i] != ' ' && !char.IsDigit(builder[i]))
            {
                builder[i] -= (char)(13);
            }
        }
        return builder.ToString();
    }

}
