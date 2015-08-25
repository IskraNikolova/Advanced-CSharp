using System;

public class MaximalSum
{
    /// <summary>
    /// a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 
    /// that has maximal sum of its elements. 
    /// </summary>
    public static void Main()
    {
        int[] rowAndColumn = { 4, 5 };
        int rows = rowAndColumn[0];
        int columns = rowAndColumn[1];
    
        int[,] matrix =
        {
            { 1, 5, 5, 2, 4 },
            { 2, 1, 4, 14, 3 },
            { 3, 7, 11, 2, 8 },
            { 4, 8, 12, 16, 4 }
        };

        int maxSum = int.MinValue;
        int maxSumRow = 0;
        int maxSumCol = 0;
        for (int row = 0; row < rows - 2; row++)
        {
            for (int column = 0; column < columns - 2; column++)
            {
                int sum = matrix[row, column] + matrix[row, column + 1] + matrix[row, column + 2]
                          + matrix[row + 1, column] + matrix[row + 1, column + 1] + matrix[row + 1, column + 2]
                          + matrix[row + 2, column] + matrix[row + 2, column + 1] + matrix[row + 2, column + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxSumRow = row;
                    maxSumCol = column;
                }
            }
        }

        Console.WriteLine("sum = {0}", maxSum);

        for (int i = maxSumRow; i <= maxSumRow + 2; i++)
        {
            for (int j = maxSumCol; j <= maxSumCol + 2; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

