using System;
using System.Linq;

public class LargerThanNeighbours
{
    public static void Main()
    {
        int[] numberForCheck = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numberForCheck.Length; i++)
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
        bool isLarge = false;
        if (index > 0 && index < number.Length - 1)
        {
            isLarge = number[index] > number[index + 1] && number[index] > number[index - 1];
        }
        else if(index == 0)
        {
            isLarge = number[index] > number[index + 1];
        }
        else
        {
            isLarge = number[index] > number[index - 1];
        }

        return isLarge;
    }
}


