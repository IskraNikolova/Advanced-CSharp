using System;
using System.Collections.Generic;
using System.Linq;

public class LongestIncreasingSequence
{
    /// <summary>
    /// A program to find all increasing sequences inside an array of integers.
    /// Find also the longest increasing sequence and print it at the last line. 
    /// </summary>
    public static void Main()
    {
        int[] inputNumbers = Console.ReadLine()
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

        int largestCountOfSequences = 0;
        List<int> largestSequence = new List<int>();
        string result = String.Empty;

        for (int index = 0; index < inputNumbers.Length - 1; index++)
        {
            if (inputNumbers[index] < inputNumbers[index + 1])
            {
                largestSequence.Add(inputNumbers[index]);

                if (index == inputNumbers.Length - 2)
                {
                    largestSequence.Add(inputNumbers[index + 1]);
                    Console.WriteLine(string.Join(" ", largestSequence));

                    if (largestCountOfSequences < largestSequence.Count)
                    {
                        largestCountOfSequences = largestSequence.Count;
                        result = string.Join(" ", largestSequence);
                    }
                }
            }
            else
            {
                largestSequence.Add(inputNumbers[index]);
                Console.WriteLine(string.Join(" ", largestSequence));

                if (largestCountOfSequences < largestSequence.Count)
                {
                    largestCountOfSequences = largestSequence.Count;
                    result = string.Join(" ", largestSequence);

                }

                largestSequence.Clear();
                if (index == inputNumbers.Length - 2)
                {
                    largestSequence.Add(inputNumbers[index + 1]);
                    Console.WriteLine(string.Join(" ", largestSequence));
                }
            }
        }

        Console.WriteLine("Longest: {0}", result);
    }
}

