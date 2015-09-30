using System;

class LabyrinthDash
{
    static void Main()
    {
        const string ObstacleSymbols = "*#@";
        int n = int.Parse(Console.ReadLine());
        char[][] jaggedLabyrinth = new char[n][];
        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();
            jaggedLabyrinth[i] = inputLine.ToCharArray();
        }
        int lives = 3;
        int col = 0;
        int row = 0;
        int moves = 0;
        string commands = Console.ReadLine();
        for (int i = 0; i < commands.Length; i++)
        {
            int previousRow = row;
            int previousCol = col;
            switch (commands[i])
            {
                case '<':
                    col--;
                    break;
                case '>':
                    col++;
                    break;
                case 'v':
                    row++;
                    break;
                case '^':
                    row--;
                    break;
            }
            if (!IsCellInsideLabyrinth(row, col, jaggedLabyrinth) || jaggedLabyrinth[row][col] == ' ')
            {
                Console.WriteLine("Fell off a cliff! Game Over!");
                moves++;
                break;
            }
            if (jaggedLabyrinth[row][col] == '_' || jaggedLabyrinth[row][col] == '|')
            {
                Console.WriteLine("Bumped a wall.");
                row = previousRow;
                col = previousCol;
            }
            else if (ObstacleSymbols.Contains(jaggedLabyrinth[row][col].ToString()))
            {
                lives--;
                moves++;
                if (lives > 0)
                {
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", lives);
                }
                else
                {

                    Console.WriteLine("No lives left! Game Over!");
                    break;
                }
            }

            else if (jaggedLabyrinth[row][col] == '$')
            {
                lives++;
                moves++;
                jaggedLabyrinth[row][col] = '.';
                Console.WriteLine("Awesome! Lives left: {0}", lives);
            }
            else if (jaggedLabyrinth[row][col] == '.')
            {
                moves++;
                Console.WriteLine("Made a move!");
            }
        }

        Console.WriteLine("Total moves made: {0}", moves);
    }

    private static bool IsCellInsideLabyrinth(int row, int col, char[][] jaggedLabyrinth)
    {
        bool isRowInsideLabyrinth = 0 <= row && row < jaggedLabyrinth.Length;

        bool isColInRange = 0 <= col && col < jaggedLabyrinth[row].Length;

        return isRowInsideLabyrinth && isColInRange;
    }
}
