using System;
using System.Linq;
using System.Text;

public class PrintBall
{
    public static void Main()
    {
        int[,] matrix = new int[10,10];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = 1;
            }
        }

        int count = 0;
        while (true)
        { 
            count++;
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            int[] command = input.Split(' ').Select(int.Parse).ToArray();
            int rowPoint = command[0];
            int columnPoint = command[1];
            int radius = command[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                 
                    if (row >= rowPoint - radius & row <= rowPoint + radius &
                        col >= columnPoint - radius & col <= columnPoint + radius)
                    {
                        if (count%2 != 0)
                        {
                            matrix[row, col] = 0;
                        }
                        else
                        {
                            matrix[row, col] = 1;
                        }
                    }
                }
           
            }
        }
        long sum = 0;
        StringBuilder result = new StringBuilder();
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                result.Append(matrix[r, c]);
            }
            string strResult = result.ToString();
            string reverse = new string(strResult.Reverse().ToArray());
            long numResult = Convert.ToInt64(reverse, 2);
            sum += numResult;
            result.Clear();
        }

        Console.WriteLine(sum);
    }
}

