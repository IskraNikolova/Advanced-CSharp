using System;
using System.Collections.Generic;
using System.Linq;

public class LegoBlocks
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] firstJaggedAray = new int[rows][];
        int[][] secondJaggedAray = new int[rows][];


        List<int> rowsOfFirstAray = new List<int>();
        List<int> rowsOfSecondAray = new List<int>();
        for (int i = 0; i < rows; i++)
        {
            rowsOfFirstAray = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            firstJaggedAray[i] = rowsOfFirstAray.ToArray();
        }

        for (int i = 0; i < rows; i++)
        {
            rowsOfSecondAray = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            secondJaggedAray[i] = rowsOfSecondAray.ToArray();
        }

        bool revision = true;


        int rowLenght = firstJaggedAray[0].Length + secondJaggedAray[0].Length;
        int counterblocks = rowLenght;

        for (int i = 1; i < rows; i++)
        {
            int leftSide = firstJaggedAray[i].Length;
            int rightSide = secondJaggedAray[i].Length;

            counterblocks += leftSide + rightSide;
            if (firstJaggedAray[i].Length + secondJaggedAray[i].Length != rowLenght)
            {
                revision = false;
            }
        }

        if (revision)
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                int length = firstJaggedAray[i].Length + secondJaggedAray[i].Length;


                int[] result = new int[length];

                for (int j = 0; j < length; j++)
                {
                    if (j < firstJaggedAray[i].Length)
                    {
                        result[j] = firstJaggedAray[i][j];
                    }

                    else
                    {

                        result[j] = secondJaggedAray[i][(secondJaggedAray[i].Length - 1) - count];
                        count++;
                    }
                }

                Console.WriteLine("[" + string.Join(", ", result) + "]");
                count = 0;
            }
        }
        else
        {
            Console.WriteLine("The total number of cells is: " + counterblocks);
        }
    }
}
