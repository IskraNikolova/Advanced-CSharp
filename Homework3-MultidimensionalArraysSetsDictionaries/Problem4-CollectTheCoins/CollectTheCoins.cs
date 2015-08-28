using System;
using System.Collections.Generic;

//Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.
//You receive the layout of a board from the console.Assume it will always have 4 rows which you'll get as strings, each on a separate line. 
//Each character in the strings will represent a cell on the board. Note that the strings may be of different length.
//You are the player and start at the top-left corner (that would be position [0, 0] on the board). On the fifth line of input you'll 
//receive a string with movement commands which tell you where to go next, it will contain only these four characters – '>' (move right),
//'<' (move left), '^' (move up) and 'v' (move down). You need to keep track of two types of events – collecting coins(represented by the symbol '$',
//of course) and hitting the walls of the board(when the player tries to move off the board to invalid coordinates). When all moves are over, print 
//the amount of money collected and the number of walls hit.

public class CollecTheCoins
{
    public static void Main()
    {
        List<string> field = new List<string>();
        for (int row = 0; row < 4 ; row++)
        {
            string line = Console.ReadLine();
            field.Add(line);
        }

        string commands = Console.ReadLine();

        int coins = 0;
        int hits = 0;
      
        for (int step = 0, row = 0, column = 0; step < commands.Length; step++)
        {
            switch (commands[step])
            {
                case 'V':
                    row++;
                    if (row > field.Count - 1 || column > field[row].Length)
                    {
                        hits++;
                        row--;
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

                case '>':
                    column++;
                    if (column > field[row].Length - 1)
                    {
                        hits++;
                        column--;
                    }
                    break;

                case '<':
                    column--;
                    if (row < 0)
                    {
                        hits++;
                        column++;
                    }
                    break;
            }

        if (field[row][column] == '$')
        {
            coins++;
        }
    }
         Console.WriteLine("Coins collected: {0}", coins);
         Console.WriteLine("Walls hit: {0}", hits);

    }
}

