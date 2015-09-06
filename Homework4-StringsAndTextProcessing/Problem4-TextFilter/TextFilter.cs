using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TextFilter
{
    /// <summary>
    /// A program that takes a text and a string of banned words. All words included in the ban list should be replaced with asterisks "*",
    ///  equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
    /// </summary>
    public static void Main()
    {
        List<string> banWords = Console.ReadLine().Split(new []{',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
        string text = Console.ReadLine();

        StringBuilder textBuilder = new StringBuilder(text);
        for (int i = 0; i < banWords.Count; i++)
        {
            int lengthOfWords = banWords[i].Length;
            for (int j = 0; j < text.Length - (lengthOfWords - 1); j++)
            {
                string subString = text.Substring(j, lengthOfWords);
                if (banWords[i] == subString)
                {
                    string newValue = new string('*', subString.Length);
                    textBuilder.Replace(subString, newValue, j, newValue.Length);
                }
            }
        }

        Console.WriteLine(textBuilder.ToString());

    }
}

