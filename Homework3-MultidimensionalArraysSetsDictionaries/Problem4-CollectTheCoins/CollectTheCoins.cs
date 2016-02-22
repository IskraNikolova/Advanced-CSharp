namespace Problem4_CollectTheCoins
{
    using System;

    public class CollectTheCoins
    {
        public static void Main()
        {
            var board = FillTheBoard();

            string commands = Console.ReadLine();

            int coins = 0;
            int hits = 0;
            for (int step = 0, row = 0, column = 0; step < commands.Length - 1; step++)
            {
                switch (commands[step])
                {
                    case 'V':
                        row = StepDown(row, board, column, ref hits);
                        break;
                    case '>':
                        column = StepRight(column, board, row, ref hits);
                        break;
                    case '<':
                        column = StepLeft(column, ref hits);
                        break;
                    case '^':
                        row = StepUp(row, ref hits);
                        break;
                }

                if (board[row][column] == '$')
                {
                    coins++;
                }
            }

            PrintResult(coins, hits);
        }

        private static void PrintResult(int coins, int hits)
        {
            Console.WriteLine("Coins collected: {0}", coins);

            Console.WriteLine("Walls hit: {0}", hits);
        }

        private static int StepUp(int row, ref int hits)
        {
            row--;
            if (row < 0)
            {
                hits++;
                row++;
            }

            return row;
        }

        private static int StepLeft(int column, ref int hits)
        {
            column--;
            if (column < 0)
            {
                hits++;
                column++;
            }

            return column;
        }

        private static int StepRight(int column, string[] board, int row, ref int hits)
        {
            column++;
            if (column > board[row].Length - 1)
            {
                hits++;
                column--;
            }

            return column;
        }

        private static int StepDown(int row, string[] board, int column, ref int hits)
        {
            row++;
            if (row > board.Length - 1 || column > board[row].Length)
            {
                hits++;
                row--;
            }

            return row;
        }

        private static string[] FillTheBoard()
        {
            const int lengthOfBoard = 4;

            string[] board = new string[lengthOfBoard];
            for (int row = 0; row < lengthOfBoard; row++)
            {
                string input = Console.ReadLine();

                board[row] = input;
            }

            return board;
        }
    }
}

