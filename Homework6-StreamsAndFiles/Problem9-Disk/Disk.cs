using System;

public class Disk
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int center = n/2;

        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < n; column++)
            {

                double checRadius = Math.Sqrt(Math.Pow(column - center, 2) + Math.Pow(row - center, 2));
                if (checRadius <= radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
