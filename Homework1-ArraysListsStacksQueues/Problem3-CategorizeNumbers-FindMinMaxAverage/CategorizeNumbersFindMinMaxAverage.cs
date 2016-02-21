namespace Problem3_CategorizeNumbers_FindMinMaxAverage
{
    using System;
    using System.Linq;

    public class CategorizeNumbersFindMinMaxAverage
    {
        public static void Main()
        {
            double[] collectionOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var roundNumbers = collectionOfNumbers
                .Where(number => (number == (int)number));

            var notRoundNumbers = collectionOfNumbers
                .Where(number => (number != (int)number));

            double minNotRoundNumber = notRoundNumbers.Min();
            double maxNotRoundNumber = notRoundNumbers.Max();
            double sumOfNotRoundNumbers = notRoundNumbers.Sum();
            double averageOfNotRoundNumbers = notRoundNumbers.Average();

            Console.WriteLine(
                "[{0}]-> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", notRoundNumbers),
                minNotRoundNumber,
                maxNotRoundNumber,
                sumOfNotRoundNumbers,
                averageOfNotRoundNumbers);

            double minRoundNumber = roundNumbers.Min();
            double maxRoundNumber = roundNumbers.Max();
            double sumOfRoundNumbers = roundNumbers.Sum();
            double averageOfRoundNumbers = roundNumbers.Average();

            Console.WriteLine(
                "[{0}]-> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", roundNumbers),
                minRoundNumber,
                maxRoundNumber,
                sumOfRoundNumbers,
                averageOfRoundNumbers);
        }
    }
}