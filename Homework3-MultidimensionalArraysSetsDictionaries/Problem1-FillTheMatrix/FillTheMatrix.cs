namespace Problem1_FillTheMatrix
{
    using System;

    public class FillTheMatrix
    {
        private static void Main()
        {
            int nSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[nSize, nSize];
        
            FillingAMatrixTopToBottom(nSize, matrix);
            PrintMatrix(nSize, matrix);

            Console.WriteLine("*****************************");

            FillingAMatrixLeftToRight(nSize, matrix);
            PrintMatrix(nSize, matrix);
        }

        public static void FillingAMatrixTopToBottom(int nSize, int[,] matrix)
        {
            for (int row = 0; row < nSize; row++)
            {
                for (int col = 0, num = 0; col < nSize; num = num + nSize, col++)
                {
                    matrix[row, col] = (row + 1) + num;
                }
            }
        }

        public static void FillingAMatrixLeftToRight(int nSize, int[,] matrix)
        {
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
        }

        public static void PrintMatrix(int nSize, int[,] matrix)
        {
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
}

