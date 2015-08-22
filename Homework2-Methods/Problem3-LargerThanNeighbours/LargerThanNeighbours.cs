﻿using System;
using System.Linq;

public class LargerThanNeighbours
{
    public static void Main()
    {
        int[] numberForCheck = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int i = 1; i < numberForCheck.Length - 1; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numberForCheck, i));
        }
    }

    /// <summary>
    /// a method that checks if the element at given position in a given array of integers is larger 
    /// than its two neighbours (when such exist).
    /// </summary>
    /// <param name="number">check number</param>
    /// <param name="index">index of number in array</param>
    /// <returns></returns>
    public static bool IsLargerThanNeighbours(int[] number, int index)
    {
        bool isLarge = number[index] > number[index + 1] && number[index] > number[index - 1];

        return isLarge;
    }
}


