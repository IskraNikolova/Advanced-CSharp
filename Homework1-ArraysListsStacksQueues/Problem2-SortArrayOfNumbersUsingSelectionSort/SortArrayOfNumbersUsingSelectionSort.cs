using System;
using System.Linq;

public class SortArrayOfNumbersUsingSelectionSort
{
    /// <summary>
    /// A program to sort an array of numbers and then print them back on the console.
    /// !!! Use the selection sort algorithm. 
    /// </summary>
    public static void Main()
    {
        int[] collectionOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < collectionOfNumbers.Length - 1; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < collectionOfNumbers.Length; j++)
            {
                if (collectionOfNumbers[smallest] > collectionOfNumbers[j])
                {
                    smallest = j;
                }
            }

            int swap = collectionOfNumbers[smallest];
            collectionOfNumbers[smallest] = collectionOfNumbers[i];
            collectionOfNumbers[i] = swap;
        }

        Console.WriteLine(string.Join(" ", collectionOfNumbers));
    }
}

