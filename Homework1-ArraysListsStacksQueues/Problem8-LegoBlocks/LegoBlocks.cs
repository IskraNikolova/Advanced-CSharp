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
            FillFirstMatrix(rows, firstBlocks);

            List<int[]> secondBlocks = new List<int[]>();
            FillSecondReverseMatrix(rows, secondBlocks);

            var isLegoBlocks = CheckIsFitLegoBlocks(firstBlocks, secondBlocks);
            if (isLegoBlocks)
            {
                PrintPositiveResult(firstBlocks, secondBlocks);
            }
            else
            {
                int sells = FindCountOfSells(firstBlocks);
                sells += FindCountOfSells(secondBlocks);
                Console.WriteLine("The total number of cells is: {0}", sells);
            }
           
        }

        public static void PrintPositiveResult(List<int[]> firstBlocks, List<int[]> secondBlocks)
        {
            for (int row = 0; row < firstBlocks.Count; row++)
            {
                string firstBlockElement = string.Join(", ", firstBlocks[row]);
                string secondBlockElement = string.Join(", ", secondBlocks[row]);
                Console.WriteLine($"[{firstBlockElement}, {secondBlockElement}]");
            }
        }

        public static int FindCountOfSells(List<int[]> matrix)
        {
            int sells = 0;
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    sells++;
                }
            }

            return sells;
        }

        public static bool CheckIsFitLegoBlocks(List<int[]> firstBlocks, List<int[]> secondBlocks)
        {           
            bool isLegoBlocks = true;

            int column = firstBlocks[0].Length + secondBlocks[0].Length;
            for (int row = 1; row < firstBlocks.Count; row++)
            {
                if (firstBlocks[row].Length + secondBlocks[row].Length != column)
                {
                    isLegoBlocks = false;
                }
            }

            return isLegoBlocks;
        }

        private static void FillSecondReverseMatrix(int rows, List<int[]> secondBlocks)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] inputRowOfSecondBlocks = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Array.Reverse(inputRowOfSecondBlocks);

                secondBlocks.Add(inputRowOfSecondBlocks);
            }
        }

        private static void FillFirstMatrix(int rows, List<int[]> firstBlocks)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] inputRowOfFirstBlocks = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                firstBlocks.Add(inputRowOfFirstBlocks);
            }
        }
    }
}
