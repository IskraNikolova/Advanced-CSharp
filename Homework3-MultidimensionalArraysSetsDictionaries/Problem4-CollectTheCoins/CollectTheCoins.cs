using System;

public class CollectTheCoins
{
    private static void Main()
    {
        const int lengthOfBoard = 4;

        string[] board = new string[lengthOfBoard];
        for (int row = 0; row < 4; row++)
        {
            string input = Console.ReadLine();
            board[row] = input;
        }

        string commands = Console.ReadLine();

        int coins = 0;
        int hits = 0;
        for (int step = 0, row = 0, column = 0; step < commands.Length - 1; step++)
        {
            switch (commands[step])
            {
                case 'V':
                    row++;
                    if (row > board.Length - 1 || column > board[row].Length)
                    {
                        hits++;
                        row--;
                    }
                    break;
                case '>':
                    column++;
                    if (column > board[row].Length - 1)
                    {
                        hits++;
                        column--;
                    }
                    break;
                case '<':
                    column--;
                    if (column < 0)
                    {
                        hits++;
                        column++;
                    }
                    break;
                case '^':
                    row--;
                    if (row < 0)
                    {
                        hits++;
                        row++;
                    }
                    break;
            }
            if (board[row][column] == '$')
            {
                coins++;
            }
        }

        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", hits);
    }
}

