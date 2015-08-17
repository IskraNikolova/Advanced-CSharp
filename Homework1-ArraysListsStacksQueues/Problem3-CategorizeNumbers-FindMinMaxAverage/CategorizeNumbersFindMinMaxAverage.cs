using System;
using System.Collections.Generic;
using System.Linq;

public class CategorizeNumbersFindMinMaxAverage
{
    public static void Main()
    {
        double[] collectionOfNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        List<double> roundNumbers = new List<double>();
        List<double> notRoundNumbers = new List<double>();

        for (int i = 0; i < collectionOfNumbers.Length; i++)
        {
            if (collectionOfNumbers[i] == (int) collectionOfNumbers[i])
            {
                roundNumbers.Add(collectionOfNumbers[i]);
            }
            else
            {
                notRoundNumbers.Add(collectionOfNumbers[i]);
            }
        }

        Console.WriteLine("[" + string.Join(", ", notRoundNumbers) + "]"
                              + "-> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", 
                              notRoundNumbers.Min(), notRoundNumbers.Max(), 
                              notRoundNumbers.Sum(), notRoundNumbers.Average());

        Console.WriteLine("[" + string.Join(", ", roundNumbers) + "]"
                      + "-> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                      roundNumbers.Min(), roundNumbers.Max(),
                      roundNumbers.Sum(), roundNumbers.Average());
    }
}

