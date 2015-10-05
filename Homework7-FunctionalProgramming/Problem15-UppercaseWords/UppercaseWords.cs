using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

public class UppercaseWords
{
    public static void Main()
    {
        List<string> result = new List<string>();
        while (true)
        {
            StringBuilder builder = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            if (input[0] == "END")
            {
                break;
            }
            for (int i = 0; i < input.Length; i++)
            {
                string pattern = @"\b(?:\d*|\W*)([A-Z]{1,})(?:\d*|\W*)\b";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input[i]);
                foreach (Match match in matches)
                {
                    string oldString = match.Groups[1].ToString();
                    string newString = string.Empty;
                    string reverse = new string(oldString.Reverse().ToArray());
                    if (match.Groups[1].Length == 1 || oldString == reverse)
                    {
                        newString = ReplaceWithDoubleLetters(oldString);
                        input[i] = input[i].Replace(oldString, newString);
                    }
                    else
                    {
                        input[i] = input[i].Replace(oldString, reverse);
                    }
                }
               // builder.Append(input[i] + " ");
            }
           // result.Add(builder.ToString());
            Console.WriteLine(string.Join(" ", input));
        }
        //for (int i = 0; i < result.Count; i++)
        //{
        //    Console.WriteLine(SecurityElement.Escape([i]));
        //}
    }

    static string ReplaceWithDoubleLetters(string oldStr)
    {
        StringBuilder resultBuilder = new StringBuilder();
        for (int i = 0; i < oldStr.Length; i++)
        {
            resultBuilder.Append(oldStr[i]);
            resultBuilder.Append(oldStr[i]);
        }
        return resultBuilder.ToString();
    }
}

