using System;
using System.Linq;

public class SortArrayOfNumbersUsingSelectionSort
{
    /// <summary>
    /// A program to sort an array of numbers.
    /// !!! Use selection sort algorithm. 
    /// </summary>
    public static void Main()
    {
        int[] inputNumbers = Console.ReadLine()
                          .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

        for (int i = 0; i < inputNumbers.Length - 1; i++)
        {
            for (int j = i + 1; j < inputNumbers.Length; j++)
            {
                if (inputNumbers[i] > inputNumbers[j])
                {
                    int swapNumber = inputNumbers[i];
                    inputNumbers[i] = inputNumbers[j];
                    inputNumbers[j] = swapNumber;
                }
            }
        }

        Console.WriteLine(string.Join(" ", inputNumbers));
    }
}

