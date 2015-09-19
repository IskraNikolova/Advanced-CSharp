using System;
using System.Linq;

public class SequencesOfEqualStrings
{
    /// <summary>
    /// A program that reads an array of strings and finds in it all sequences of equal elements.
    /// </summary>
    public static void Main()
    {
        string[] input = Console.ReadLine()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1 && input[i] == input[i + 1])
            {
                Console.Write("{0} ", input[i]);
            }
            else
            {
                Console.Write("{0} ", input[i]);
                Console.WriteLine();
            }
        }
    }
}

