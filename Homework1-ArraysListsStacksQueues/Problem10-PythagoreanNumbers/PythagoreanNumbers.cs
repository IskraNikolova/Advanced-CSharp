using System;

public class PythagoreanNumbers
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] inputNumbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            int number = int.Parse(Console.ReadLine());
            inputNumbers[i] = number;
        }

        bool check = false;
        for (int a = 0; a < inputNumbers.Length; a++)
        {
            for (int b = 0; b < inputNumbers.Length; b++)
            {
                for (int c = 0; c < inputNumbers.Length; c++)
                {
                    if (inputNumbers[a] <= inputNumbers[b] && 
                          Math.Pow(inputNumbers[a], 2) + Math.Pow(inputNumbers[b], 2) ==
                          Math.Pow(inputNumbers[c], 2))
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", inputNumbers[a], inputNumbers[b], inputNumbers[c]);

                        check = true;
                    }
                }
            }
        }

        if (!check)
        {
            Console.WriteLine("No");
        }
    }
}
