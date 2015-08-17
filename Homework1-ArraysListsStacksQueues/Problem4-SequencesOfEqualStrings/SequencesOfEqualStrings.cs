using System;
using System.Collections.Generic;
using System.Linq;

public class SequencesOfEqualStrings
{
    /// <summary>
    /// A program that reads an array of strings and finds in it all sequences of equal elements.
    /// </summary>
    public static void Main()
    {
        string[] inputStrings = Console.ReadLine().Split(' ').ToArray();

        List<string> sequences = new List<string>();
        for (int i = 0; i < inputStrings.Length - 1; i++)
        {
            if (inputStrings[i] != inputStrings[i + 1])
            {
                sequences.Add(inputStrings[i]);
                Console.WriteLine(string.Join(" ", sequences));
                sequences.Clear();
            }
            if (inputStrings[i] == inputStrings[i + 1])
            {
                sequences.Add(inputStrings[i]);
                if (i == inputStrings.Length - 2)
                {
                    Console.Write("{0} ", inputStrings[i + 1]);
                }
            }

        }
        if (inputStrings[inputStrings.Length - 2] != inputStrings[inputStrings.Length - 1])
        {
            Console.Write(inputStrings[inputStrings.Length - 1]);
        }
       
        Console.WriteLine(string.Join(" ", sequences));
    }
}

