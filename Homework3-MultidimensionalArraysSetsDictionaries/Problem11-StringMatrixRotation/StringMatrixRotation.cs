using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class StringMatrixRotation
{
    public static void Main()
    {
     
        string input = Console.ReadLine();

        int maxLength = 0;
        List<string> board = new List<string>();
        while (true)
        {
            string textToRotate = Console.ReadLine();
            if (textToRotate.Length > maxLength)
            {
                maxLength = textToRotate.Length;
            }
            if (textToRotate == "END")
            {
                break;
            }
            board.Add(textToRotate);
        }

        char[,] matrixBoard = FillMatrixBoard(board, maxLength);

        int result = TakeDegrees(input);
        switch (result)
        {
            case 1:
                RotateNinety(matrixBoard);
                break;
            case 2:
                RotateHundredАndЕighty(matrixBoard);
                break;
            case 3:
                RotateTwoHundredAndSeventy(matrixBoard);
                break;
            default:
                PrintMatrix(matrixBoard);
                break;

        }
    }

    private static char[,] FillMatrixBoard(List<string> board, int maxLength)
    {
        char[,] matrixBoard = new char[board.Count, maxLength];
        for (int row = 0; row < matrixBoard.GetLength(0); row++)
        {
            for (int col = 0; col < matrixBoard.GetLength(1); col++)
            {
                if (col >= board[row].Length)
                {
                    matrixBoard[row, col] = ' ';
                }
                else
                {
                    matrixBoard[row, col] = board[row][col];
                }
            }
        }
        return matrixBoard;
    }

    private static int TakeDegrees(string input)
    {
        string pattern = @"(?<=\()\d+";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);
        string matchTostring = match.Value;
        int rotate = int.Parse(matchTostring);
        int result = (rotate/90)%4;
        return result;
    }

    private static void PrintMatrix(char[,] matrixBoard)
    {
        for (int row = 0; row < matrixBoard.GetLength(0); row++)
        {
            for (int col = 0; col < matrixBoard.GetLength(1); col++)
            {
                Console.Write(matrixBoard[row, col]);
            }
            Console.WriteLine();
        }
    }
    private static void RotateNinety(char[,] matrixBoard)
    {
        for (int col = 0; col < matrixBoard.GetLength(1); col++)
        {
            for (int row = matrixBoard.GetLength(0) - 1; row >= 0; row--)
            {
                Console.Write(matrixBoard[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void RotateHundredАndЕighty(char[,] matrixBoard)
    {
        for (int row = matrixBoard.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = matrixBoard.GetLength(1) - 1; col >= 0; col--)
            {
                Console.Write(matrixBoard[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void RotateTwoHundredAndSeventy(char[,] matrixBoard)
    {
        for (int col = matrixBoard.GetLength(1) - 1; col >= 0; col--)
        {
            for (int row = 0; row < matrixBoard.GetLength(0); row++)
            {
                Console.Write(matrixBoard[row, col]);
            }
            Console.WriteLine();
        }
      
    }
}

