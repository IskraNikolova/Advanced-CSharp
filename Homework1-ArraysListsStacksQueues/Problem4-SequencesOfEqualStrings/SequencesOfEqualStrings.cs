using System;
using System.Linq;

public class SequencesOfEqualStrings
{
    /// <summary>
    /// A program that reads an array of strings and finds in it all sequences of equal elements.
    /// </summary>
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                Console.Write(input[i] + " ");
                if (i == input.Length - 2)
                {
                    Console.Write(input[i + 1]);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write(input[i] + " ");
                Console.WriteLine();
                if (i == input.Length - 2)
                {
                    Console.WriteLine(input[i + 1]);
                }
            }
        }
    }
}

