using System;
using System.Collections.Generic;
using System.Linq;

public class CountSymbols
{
    /// <summary>
    /// A program that reads some text from the console and counts the occurrences of each character in it.
    ///  Print the results in alphabetical (lexicographical) order
    /// </summary>
    public static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<char, int> sortInputChars = new SortedDictionary<char, int>();

        foreach (var element in input)
        {
            if (sortInputChars.ContainsKey(element))
            {
                sortInputChars[element]++;
               
            }
            else
            {
                sortInputChars.Add(element, 1);
            }
        }

        foreach (var element in sortInputChars)
        {
            Console.WriteLine("{0}: {1} time/s", element.Key, element.Value);
        }
     }
}

