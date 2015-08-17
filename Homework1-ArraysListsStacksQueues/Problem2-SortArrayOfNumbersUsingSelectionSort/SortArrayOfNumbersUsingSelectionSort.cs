using System;
using System.Linq;

public class SortArrayOfNumbersUsingSelectionSort
{
    /// <summary>
    /// A program to sort an array of numbers and then print them back on the console. 
    /// </summary>
    public static void Main()
    {
        int[] collectionOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        while (true)
        {
            bool hasSwapped = false;
            for (int number = 0; number < collectionOfNumbers.Length - 1; number++)
            {
                if (collectionOfNumbers[number] > collectionOfNumbers[number + 1])
                {
                    int oldValue = collectionOfNumbers[number];
                    collectionOfNumbers[number] = collectionOfNumbers[number + 1];
                    collectionOfNumbers[number + 1] = oldValue;
                    hasSwapped = true;
                }
             
            }
            if (hasSwapped == false)
            {
                break;
            }
        }
        Console.WriteLine(string.Join(" ", collectionOfNumbers));
    }
}

