using System;

public class FirstLargerThanNeighbours
{
    public static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    public static int GetIndexOfFirstElementLargerThanNeighbours(int[] sequence)
    {
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > sequence[i + 1])
            {
                return sequence[i];
            }
        }
        return -1;
    }
}
