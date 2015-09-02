using System;
using System.Collections.Generic;
using System.Linq;

public class PlusRemove
{
    public static void Main()
    {
        List<char[]> matrix = new List<char[]>();
        List<List<char>> copyMatrix = new List<List<char>>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            matrix.Add(input.ToLower().ToCharArray());
            copyMatrix.Add(input.ToList());
        }

        for (int row = 1; row < matrix.Count - 1; row++)
        {
            for (int col = 1; col < matrix[row].Length - 1; col++)
            {

                if (col <= matrix[row - 1].Length - 1 &&
                    col <= matrix[row + 1].Length - 1)
                {
                    if (matrix[row][col] == matrix[row + 1][col] &&
                        matrix[row][col] == matrix[row - 1][col] &&
                        matrix[row][col] == matrix[row][col + 1] &&
                        matrix[row][col] == matrix[row][col - 1])
                    {
                        copyMatrix[row][col] = ' ';
                        copyMatrix[row - 1][col] = ' ';
                        copyMatrix[row + 1][col] = ' ';
                        copyMatrix[row][col + 1] = ' ';
                        copyMatrix[row][col - 1] = ' ';
                    }
                }
            }
        }

        //foreach (List<char> element in copyMatrix)
        //{
        //    for (int row = 0; row < element.Count; row++)
        //    {
        //        element.Remove(' ');
                
        //    }
        //}

        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < copyMatrix[row].Count; col++)
            {
                Console.Write(copyMatrix[row][col].ToString().Trim());
                
            }
            Console.WriteLine();
        }
    }

}

