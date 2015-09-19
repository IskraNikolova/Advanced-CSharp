using System;
using System.Collections.Generic;

public class SequenceInMatrix
{
    private static void Main()
    {
        Console.Write("N = ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("M = ");
        int columns = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        string columnSequence = SearchSequenceInColumnsOfMatrix(matrix);
        string rowSequence = SearchSequenceInRowsOfMatrix(matrix);
        string leftDiagonalSequence = SearchSequenceInLeftDiagonalOfMatrix(matrix);
        string rightDiagonalSequence = SearchSequenceInRightDiagonalOfMatrix(matrix);

        string toResult = FindMaxSequences(columnSequence, rowSequence, leftDiagonalSequence, rightDiagonalSequence);
        PrintResult(toResult);
    }

    //Method that finds the longest sequence of equal strings in the rows in the matrix.
    public static string SearchSequenceInRowsOfMatrix(string[,] matrix)
    {
        List<string> sequenceInMatrixRowList = new List<string>();
        string rowSequence = string.Empty;
        int counterRow = 0;
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            sequenceInMatrixRowList.Clear();
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                if (matrix[row, column] == matrix[row + 1, column])
                {
                    sequenceInMatrixRowList.Add(matrix[row, column]);
                }
            }
            if (sequenceInMatrixRowList.Count > counterRow)
            {
                counterRow = sequenceInMatrixRowList.Count;
                rowSequence = sequenceInMatrixRowList[0];
            }
        }
        if (rowSequence == string.Empty)
        {
            rowSequence = "no";
        }
        return rowSequence + " " + counterRow;
    }

    //Method that finds the longest sequence of equal strings in the columns in the matrix.
    public static string SearchSequenceInColumnsOfMatrix(string[,] matrix)
    {
        List<string> sequenceInMatrixColumnList = new List<string>();
        string columnSequence = string.Empty;
        int counterColumn = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            sequenceInMatrixColumnList.Clear();
            for (int column = 0; column < matrix.GetLength(1) - 1; column++)
            {
                if (column <= matrix.GetLength(1) - 1)
                {
                    if (matrix[row, column] == matrix[row, column + 1])
                    {
                        sequenceInMatrixColumnList.Add(matrix[row, column]);
                    }
                }

            }
            if (sequenceInMatrixColumnList.Count > counterColumn)
            {
                counterColumn = sequenceInMatrixColumnList.Count;
                columnSequence = sequenceInMatrixColumnList[0];
            }
        }
        if (columnSequence == string.Empty)
        {
            columnSequence = "no";
        }
        return columnSequence + " " + counterColumn;
    }

    //Method that finds the longest sequence of equal strings in the left diagonals in the matrix.
    public static string SearchSequenceInLeftDiagonalOfMatrix(string[,] matrix)
    {

        List<string> sequenceInMatrixLeftDiagonalList = new List<string>();
        string leftDiagonalSequence = string.Empty;
        int counterLeftDiagonal = 0;

        for (int count = 0; count < matrix.GetLength(0) - 1; count++)
        {
            sequenceInMatrixLeftDiagonalList.Clear();
            for (int row = count, column = 0; row < matrix.GetLength(0) - 1; column++, row++)
            {
                if (matrix[row, column] == matrix[row + 1, column + 1])
                {
                    sequenceInMatrixLeftDiagonalList.Add(matrix[row, column]);
                }
            }

            if (sequenceInMatrixLeftDiagonalList.Count > counterLeftDiagonal)
            {
                counterLeftDiagonal = sequenceInMatrixLeftDiagonalList.Count;
                leftDiagonalSequence = sequenceInMatrixLeftDiagonalList[0];
            }
        }

        for (int count = 0; count < matrix.GetLength(1) - 1; count++)
        {
            sequenceInMatrixLeftDiagonalList.Clear();
            for (int column = count + 1, row = 0; column < matrix.GetLength(1) - 1; row++, column++)
            {
                if (matrix[row, column] == matrix[row + 1, column + 1])
                {
                    sequenceInMatrixLeftDiagonalList.Add(matrix[row, column]);
                }
            }

            if (sequenceInMatrixLeftDiagonalList.Count > counterLeftDiagonal)
            {
                counterLeftDiagonal = sequenceInMatrixLeftDiagonalList.Count;
                leftDiagonalSequence = sequenceInMatrixLeftDiagonalList[0];
            }
        }
        if (leftDiagonalSequence == string.Empty)
        {
            leftDiagonalSequence = "no";
        }
        return leftDiagonalSequence + " " + counterLeftDiagonal;
    }

    //Method that finds the longest sequence of equal strings in the right diagonals in the matrix.
    public static string SearchSequenceInRightDiagonalOfMatrix(string[,] matrix)
    {
        List<string> sequenceInMatrixRightDiagonalList = new List<string>();
        string rightDiagonalSequence = string.Empty;
        int counterRightDiagonal = 0;

        for (int count = 0; count < matrix.GetLength(0) - 2; count++)
        {
            sequenceInMatrixRightDiagonalList.Clear();
            for (int row = (matrix.GetLength(0) - 1) - count, column = 0; row > 0; column++, row--)
            {
                if (matrix[row, column] == matrix[row - 1, column + 1])
                {
                    sequenceInMatrixRightDiagonalList.Add(matrix[row, column]);

                }
            }

            if (sequenceInMatrixRightDiagonalList.Count > counterRightDiagonal)
            {
                counterRightDiagonal = sequenceInMatrixRightDiagonalList.Count;
                rightDiagonalSequence = sequenceInMatrixRightDiagonalList[0];
            }
        }

        for (int count = 0; count < matrix.GetLength(1) - 2; count++)
        {
            sequenceInMatrixRightDiagonalList.Clear();
            for (int column = 1 + count, row = matrix.GetLength(0) - 1; column < matrix.GetLength(1) - 1; row--, column++)
            {
                if (matrix[row, column] == matrix[row - 1, column + 1])
                {
                    sequenceInMatrixRightDiagonalList.Add(matrix[row, column]);

                }
            }
            if (sequenceInMatrixRightDiagonalList.Count > counterRightDiagonal)
            {
                counterRightDiagonal = sequenceInMatrixRightDiagonalList.Count;
                rightDiagonalSequence = sequenceInMatrixRightDiagonalList[0];
            }
        }

        if (rightDiagonalSequence == string.Empty)
        {
            rightDiagonalSequence = "no";
        }

        return rightDiagonalSequence + " " + counterRightDiagonal;
    }



    //Search max long sequences.
    public static string FindMaxSequences(string columnSequence, string rowSequence,
        string leftDiagonalSequence, string rightDiagonalSequence)
    {
        string[] elements = new[]
        {
            columnSequence.Split(' ')[0], rowSequence.Split(' ')[0],
            leftDiagonalSequence.Split(' ')[0], rightDiagonalSequence.Split(' ')[0]
        };

        int[] counts = new[]
        {
            int.Parse(columnSequence.Split(' ')[1]), int.Parse(rowSequence.Split(' ')[1]),
            int.Parse(leftDiagonalSequence.Split(' ')[1]), int.Parse(rightDiagonalSequence.Split(' ')[1])
        };
        int maxCount = 0;
        string elementWithMaxCount = String.Empty;

        for (int i = 0; i < elements.Length; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                elementWithMaxCount = elements[i];
            }
        }

        maxCount++;
        return elementWithMaxCount + " " + maxCount;
    }

    //Print result.
    public static void PrintResult(string toResult)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < int.Parse(toResult.Split(' ')[1]); i++)
        {
            result.Add(toResult.Split(' ')[0]);
        }

        Console.WriteLine(string.Join(", ", result));
    }
}



