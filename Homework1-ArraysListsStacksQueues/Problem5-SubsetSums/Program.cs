using System;
using System.Collections.Generic;
using System.Linq;

public class SubsetSums
{
    /// <summary>
    /// A program that reads from the console a number N and an array of integers given on a single line.
    /// Task is to find all subsets within the array which have a sum equal to N and print them on the 
    /// console (the order of printing is not important). Only the unique subsets by filtering out
    ///  repeating numbers first. In case there aren't any subsets with the desired sum, print 
    /// "No matching subsets."
    /// </summary>

    static bool solution;
    public static void Main()
    {
        Console.Write("sum: ");
        int sum = int.Parse(Console.ReadLine());

        Console.Write("Sequence of numbers: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

        List<int> subset = new List<int>();
        MakeSubset(0, sum, subset, numbers);

        if (!solution)
        {
            Console.WriteLine("No matching subsets.");
        }
      
    }

    public static void MakeSubset(int index, int sum, List<int> subset, int[] numbers)
    {
        if (subset.Sum() == sum && subset.Count > 0) 
        {
            Console.WriteLine(" {0} = {1}", string.Join(" + ", subset), sum);
            solution = true;
        }
        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]);
            MakeSubset(i + 1, sum, subset, numbers); 
            subset.RemoveAt(subset.Count - 1); 
        }
    }
}

