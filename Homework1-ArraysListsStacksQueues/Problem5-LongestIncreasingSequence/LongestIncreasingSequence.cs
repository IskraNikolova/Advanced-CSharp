using System;
using System.Collections.Generic;
using System.Linq;

public class LongestIncreasingSequence
{
    /// <summary>
    /// Write a program to find all increasing sequences inside an array of integers and 
    /// find also the longest increasing sequence and print it at the last line.
    /// </summary>
    public static void Main()
    {
        int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int maxCount = 0;

        List<int> sequenseOfNumbers = new List<int>();
        List<int> maxSequences = new List<int>();
        for (int i = 0; i < inputNumbers.Length - 1; i++)
        {
            if (inputNumbers[i] < inputNumbers[i + 1])
            {
                sequenseOfNumbers.Add(inputNumbers[i]);
            }
         
            else
            {
                sequenseOfNumbers.Add(inputNumbers[i]);
                if (sequenseOfNumbers.Count > maxCount)
                {
                    maxSequences.Clear();
                    maxCount = sequenseOfNumbers.Count;
                    CopyMaxSequencesOfNumber(sequenseOfNumbers, maxSequences);
                }

                Console.WriteLine(string.Join(" ", sequenseOfNumbers));
                sequenseOfNumbers.Clear();
            }

            if (inputNumbers[i] < inputNumbers[i + 1] && i == inputNumbers.Length - 2)
            {
                sequenseOfNumbers.Add(inputNumbers[i + 1]);

                Console.WriteLine(string.Join(" ", sequenseOfNumbers));
                if (sequenseOfNumbers.Count > maxCount)
                {
                    maxSequences.Clear();
                    maxCount = sequenseOfNumbers.Count;
                    CopyMaxSequencesOfNumber(sequenseOfNumbers, maxSequences);
                }
            }

        }

        Console.WriteLine("Longest: " + string.Join(" ", maxSequences));
    }

    static List<int> CopyMaxSequencesOfNumber(List<int> sequenseOfNumbers, List<int> maxSequences)
    {
        for (int j = 0; j < sequenseOfNumbers.Count; j++)
        {
            maxSequences.Add(sequenseOfNumbers[j]);
        }

        return maxSequences;
    } 
}

