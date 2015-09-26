using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class SemanticHTML
{
    public static void Main()
    {

        List<string> htmlCode = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            htmlCode.Add(input);
        }
        int count = 0;
        while (count <= htmlCode.Count / 2)
        {
            string nameTag = string.Empty;
            for (int i = htmlCode.Count - 1; i >= 0; i--)
            {
                count++;
                string pattern = @"<\/div>";
                Regex regex = new Regex(pattern);
                bool isHasCloseTag = regex.IsMatch(htmlCode[i]);
                if (isHasCloseTag)
                {
                    string patternForNameTag = @"\s*<!--\s*(nav|header|main|article|section|aside|footer)(.*)";
                    Regex regexForNameTag = new Regex(patternForNameTag);
                    Match match = regexForNameTag.Match(htmlCode[i]);
                    nameTag = match.Groups[1].ToString();

                    string replaceCloseTag = $"</{nameTag}>";
                    htmlCode[i] = regex.Replace(htmlCode[i], replaceCloseTag);
                    string removeReplace = string.Empty;
                    htmlCode[i] = regexForNameTag.Replace(htmlCode[i], removeReplace);
                    break;
                }

            }

            for (int i = 0; i < htmlCode.Count; i++)
            {
                string pattern = @"<div";
                Regex regex = new Regex(pattern);
                bool isHasOpenDivTag = regex.IsMatch(htmlCode[i]);
                if (isHasOpenDivTag)
                {
                    string patternOfIDOrClass = @"(\s*id\s*=\s*""\w+""\s*|\s*class\s*=\s*""\w+""\s*)";
                    Regex regexForIDOrCLass = new Regex(patternOfIDOrClass);
                    Match match = regexForIDOrCLass.Match(htmlCode[i]);

                    string replace = string.Empty;
                    int indexOfMatch = match.Groups[1].Index;
                    int countOfMatch = match.Groups[1].Length;
                    int index = (indexOfMatch + countOfMatch);
                    if (htmlCode[i][index] != '>')
                    {
                        htmlCode[i] = regexForIDOrCLass.Replace(htmlCode[i], " ");
                    }
                    else
                    {

                        htmlCode[i] = regexForIDOrCLass.Replace(htmlCode[i], string.Empty);
                    }
                    Regex regexFoReplace = new Regex(pattern);
                    replace = $"<{nameTag}";
                    htmlCode[i] = regexFoReplace.Replace(htmlCode[i], replace);

                    break;
                }
            }
        }
        Console.WriteLine(string.Join("\n", htmlCode));
    }
}
