using System;

public class MatrixShuffing
{
    private static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());

        //initialize the matrix
        string[,] matrix = new string[row, column];
        for (int rows = 0; rows < row; rows++)
        {
            for (int col = 0; col < column; col++)
            {
                matrix[rows, col] = Console.ReadLine();
            }
        }

        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');

            if (command[0] == "END")
            {
                break;
            }
            if (command[0] == "swap")
            {
                //take indices of change of the matrix
                int firstRow = int.Parse(command[1]);
                int firstCol = int.Parse(command[2]);
                int secondRow = int.Parse(command[3]);
                int secondCol = int.Parse(command[4]);


                //checking whether the indices are within the matrix
                if (firstRow < matrix.GetLength(0) ||
                    firstCol < matrix.GetLength(1) ||
                    secondRow < matrix.GetLength(0) ||
                    secondCol < matrix.GetLength(1))
                {

                    //replace numbers
                    string middle = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = middle;

                    //Print matrix
                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write("{0} ", matrix[rows, col]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}

