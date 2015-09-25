using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class QueryMess
{
    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string[] cutcuttingByAmpersand = input.Split('&');
            Dictionary<string, string> list = new Dictionary<string, string>();
            for (int i = 0; i < cutcuttingByAmpersand.Length; i++)
            {
                string whiteSpaceSymbol = @"(\%20|\+)";
                string replace = " ";
                Regex regex2 = new Regex(whiteSpaceSymbol);
                string result = regex2.Replace(cutcuttingByAmpersand[i], replace);

                string pattern = @"(\w+)(\s)?(=)(\s)?(\w+.*)";
                Regex regex = new Regex(pattern);
                MatchCollection match = regex.Matches(result);
                string key = string.Empty;
                string value = string.Empty;
                foreach (Match el in match)
                {
                    key = el.Groups[1].ToString();
                    value = el.Groups[5].ToString().Trim();

                }
                string patternForWhiteSpace = @"(\s{2,})";
                string replaceWhiteSpce = " ";
                Regex regexForReplace = new Regex(patternForWhiteSpace);
                string rezultValue = regexForReplace.Replace(value, replaceWhiteSpce);
                if (list.ContainsKey(key))
                {
                    list[key] += ", " + rezultValue;
                }
                else
                {
                    list.Add(key, rezultValue);
                }

            }
            foreach (var pair in list)
            {
                Console.Write("{0}=[{1}]", pair.Key, pair.Value);
            }
            Console.WriteLine();
        }
    }
}
