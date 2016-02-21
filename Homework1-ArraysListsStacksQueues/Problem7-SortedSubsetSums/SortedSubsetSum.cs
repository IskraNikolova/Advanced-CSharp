namespace Problem7_SortedSubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortedSubsetSums
    {
        private static bool isSubsetSum;

        public static void Main()
        {
            int sum = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            Array.Sort(numbers);

            List<List<int>> subsets = new List<List<int>>();
            List<int> subset = new List<int>();

            MakeSubset(0, sum, subset, numbers, subsets);

            var sorted = subsets.OrderBy(x => x.Count);
            foreach (var item in sorted)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", item), sum);
            }

            if (!isSubsetSum)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        public static void MakeSubset(int index, int sum, List<int> subset, int[] numbers, List<List<int>> subsets)
        {
            if (subset.Sum() == sum && subset.Count > 0)
            {
                subsets.Add(new List<int>(subset));
                isSubsetSum = true;
            }

            for (int i = index; i < numbers.Length; i++)
            {
                subset.Add(numbers[i]);
                MakeSubset(i + 1, sum, subset, numbers, subsets);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
