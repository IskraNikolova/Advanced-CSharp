namespace Problem3_MatrixShuffling
{
    using System;

    public class MatrixShuffing
    {
        private static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
          
            var matrix = FillTheMatrix(row, column);
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "END")
            {
                bool isValid = ValidateData(matrix, command);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input!");     
                }
                else
                {
                    Swap(matrix, command);               
                    PrintMatrix(matrix);
                }

                command = Console.ReadLine().Split(' ');
            }
        }

        private static void Swap(string[,] matrix, string[] command)
        {
            int firstRow = int.Parse(command[1]);
            int firstCol = int.Parse(command[2]);
            int secondRow = int.Parse(command[3]);
            int secondCol = int.Parse(command[4]);

            string middle = matrix[firstRow, firstCol];
            matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
            matrix[secondRow, secondCol] = middle;
        }

        public static bool ValidateData(string[,] matrix, string[] command)
        {
            bool isValid = false;

            if (command[0] == "swap")
            {
                int firstRow = int.Parse(command[1]);
                int firstCol = int.Parse(command[2]);
                int secondRow = int.Parse(command[3]);
                int secondCol = int.Parse(command[4]);

                if (firstRow < matrix.GetLength(0) && firstRow >= 0 &&
                    firstCol < matrix.GetLength(1) && firstCol >= 0 &&
                    secondRow < matrix.GetLength(0) && secondRow >= 0 &&
                    secondCol < matrix.GetLength(1) && secondCol >= 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[rows, col]);
                }

                Console.WriteLine();
            }
        }

        private static string[,] FillTheMatrix(int row, int column)
        {
            string[,] matrix = new string[row, column];
            for (int rows = 0; rows < row; rows++)
            {
                for (int col = 0; col < column; col++)
                {
                    matrix[rows, col] = Console.ReadLine();
                }
            }

            return matrix;
        }
    }
}

