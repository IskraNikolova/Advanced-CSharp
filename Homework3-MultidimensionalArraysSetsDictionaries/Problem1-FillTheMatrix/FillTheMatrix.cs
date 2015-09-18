using System;

public class FillTheMatrix
{
    private static void Main()
    {
        int nSize = int.Parse(Console.ReadLine());

        int[,] matrix = new int[nSize, nSize];

        //Filling a matrix in the regular pattern (top to bottom).
        for (int row = 0; row < nSize; row++)
        {
            for (int col = 0, num = 0; col < nSize; num = num + nSize, col++)
            {
                matrix[row, col] = (row + 1) + num;
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
        Console.WriteLine("*****************************");
    //Filling a matrix in the regular pattern (left to right).
    int count = 1;
            for (int row = 0; row < nSize; row++)
            {
                if (row%2 == 0)
                {
                    for (int column = 0; column < nSize; column++)
                    {
                        matrix[column, row] = count++;
                    }
                }
                else
                {
                    for (int column = nSize - 1; column >= 0; column--)
                    {
                        matrix[column, row] = count++;
                    }
                }
            }

            for (int row = 0; row < nSize; row++)
            {
                for (int cow = 0; cow < nSize; cow++)
                {
                    Console.Write(matrix[row, cow] + " ");
                }
                Console.WriteLine();
            }
    }
}

