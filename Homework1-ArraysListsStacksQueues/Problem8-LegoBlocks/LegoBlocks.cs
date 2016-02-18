namespace Problem8_LegoBlocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            List<int[]> firstBlocks = new List<int[]>();
            for (int row = 0; row < rows; row++)
            {
                int[] inputRowOfFirstBlocks = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                firstBlocks.Add(inputRowOfFirstBlocks);
            }

            List<int[]> secondBlocks = new List<int[]>();
            for (int row = 0; row < rows; row++)
            {
                int[] inputRowOfSecondBlocks = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Array.Reverse(inputRowOfSecondBlocks);

                secondBlocks.Add(inputRowOfSecondBlocks);
            }

            int column = firstBlocks[0].Length + secondBlocks[0].Length;
            int count = 1;
            int sells = column;
            for (int row = 1; row < rows; row++)
            {
                if (rows > 1 && firstBlocks[row].Length + secondBlocks[row].Length == column)
                {
                    count++;

                }

                sells += firstBlocks[row].Length + secondBlocks[row].Length;
            }

            if (count == rows)
            {
                for (int row = 0; row < rows; row++)
                {
                    Console.WriteLine($"[{ string.Join(", ", firstBlocks[row])}, {string.Join(", ", secondBlocks[row])}]");                  
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: {0}", sells);
            }

        }
    }
}
