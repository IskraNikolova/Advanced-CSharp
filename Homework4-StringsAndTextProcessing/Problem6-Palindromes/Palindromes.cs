using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Palindromes
{
    //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, 
    //separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. 
    //Print only unique palindromes, sorted lexicographically.

    public static void Main()
    {
        string[] text = Console.ReadLine().Split(new []{' ', ',', '.', '?','!' },
                        StringSplitOptions.RemoveEmptyEntries).ToArray();

        SortedSet<string> palindromes = new SortedSet<string>();
        for (int i = 0; i < text.Length; i++)
        {
            StringBuilder second = new StringBuilder();
            for (int j = text[i].Length - 1; j >= 0; j--)
            {
                second.Append(text[i][j]);
            }

            if (text[i] == second.ToString())
            {
                palindromes.Add(text[i]);
            }
            second.Clear();
        }

        Console.WriteLine(string.Join(", ", palindromes));
    }
}

