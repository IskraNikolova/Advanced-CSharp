using System;
using System.Security;

public class TextGravity
{
    public static void Main()
    {
        int columns = int.Parse(Console.ReadLine());
        string inputText = Console.ReadLine();
        int rows = inputText.Length / columns;
        if (inputText.Length%columns != 0)
        {
            rows++;
        }

        char[,] matrix = new char[rows, columns];
        FillTheMatrixWithString(matrix, inputText);

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            TextGravityMaker(matrix, col);
        }

        Console.Write("<table>");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("<tr>");
            for (int cow = 0; cow < matrix.GetLength(1); cow++)
            {
                Console.Write($"<td>{SecurityElement.Escape(matrix[row, cow].ToString())}</td>");
            }
            Console.Write("</tr>");
        }
        Console.Write("</table>");
    }

    private static void TextGravityMaker(char[,] matrix, int col)
    {
       
        while (true)
        {
            bool isSwap = false;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                char currentChar = matrix[row, col];
                char topChar = matrix[row - 1, col];
                if (currentChar == ' ' && topChar != ' ')
                {
                    matrix[row, col] = topChar;
                    matrix[row - 1, col] = ' ';
                    isSwap = true;
                }
            }
            if (!isSwap)
            {
                break;
            }
        }    
    }

    private static void FillTheMatrixWithString(char[,] matrix, string inputText)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int index = column + (row * matrix.GetLength(1));
                if (index > inputText.Length - 1)
                {
                    matrix[row, column] = ' ';
                }
                else
                {
                    matrix[row, column] = inputText[index];
                }
            }
        }
    }
}
