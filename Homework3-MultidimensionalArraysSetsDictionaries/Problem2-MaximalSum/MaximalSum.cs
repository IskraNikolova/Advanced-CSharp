using System;
using System.Linq;

public class MaximalSum
{
    /// <summary>
    /// A program that reads a rectangular integer matrix of size N x M and 
    /// finds in it the square 3 x 3 that has maximal sum of its elements. 
    /// </summary>
    private static void Main()
    {
        const int length = 3;

        int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = size[0];
        int column = size[1];

        int[,] matrix = new int[rows, column];
        for (int row = 0; row < rows; row++)
        {
            int[] rowOfMatrix =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            for (int col = 0; col < column; col++)
            {
                matrix[row, col] = rowOfMatrix[col];
            }
        }
        int bestSum = Int32.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }

            }
        }
        Console.WriteLine("Sum = {0}", bestSum);

        for (int row = bestRow; row < bestRow + length; row++)
        {
            for (int col = bestCol; col < bestCol + length; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

