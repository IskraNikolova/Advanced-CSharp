using System;

public class MatrixShuffing
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        //initialize the matrix
        string[,] matrix = new string[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = Console.ReadLine();
            }
        }

        bool isEnd = false;
        while (!isEnd)
        {
            string command = Console.ReadLine();
            if (command == "END")
            {
                isEnd = true;
            }

            ////take indices of change of the matrix
            string[] commands = command.Split(' ');

            if (commands[0] != "swap")
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            int firstRow = int.Parse(commands[1]);
            int firstColumn = int.Parse(commands[2]);
            int secondRow = int.Parse(commands[3]);
            int secondColumn = int.Parse(commands[4]);

            //checking whether the indices are within the matrix
            if (firstRow > matrix.GetLength(0) || secondRow > matrix.GetLength(0)
                || firstColumn > matrix.GetLength(1) || secondColumn > matrix.GetLength(1))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            //replace numbers
            string middle = matrix[firstRow, firstColumn];
            matrix[firstRow, firstColumn] = matrix[secondRow, secondColumn];
            matrix[secondRow, secondColumn] = middle;

            //Print matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

    }
}

