namespace Problem1_SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public class SortArrayOfNumbers
    {
        /// <summary>
        /// A program to read an array of numbers from the console, sort them and print them back on the console.
        /// </summary>
        public static void Main()
        {
            int[] collectionOfNumbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Array.Sort(collectionOfNumbers);

            Console.WriteLine(string.Join(" ", collectionOfNumbers));
        }
    }
}

