using System;
using System.Collections.Generic;
using System.Linq;

public class SubsetSums
{
    public static bool isSubsetSum;
    /// <summary>
    /// Find all subsets within the array which have a equal sum.
    /// </summary>
    public static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

        List<int> subset = new List<int>();

        MakeSubset(0, subset, sum, numbers);

        if (!isSubsetSum)
        {
            Console.WriteLine("No matching subsets.");
        }

    }

    public static void MakeSubset(int index, List<int> subset, int sum, int[] numbers)
    {
        if (subset.Sum() == sum && subset.Count > 0)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", subset), sum);
            isSubsetSum = true;
        }

        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]);
            MakeSubset(i + 1, subset, sum, numbers);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}