using System;

public class BiggerNumber
{
    public static void Main()
    {
        int firstInteger = int.Parse(Console.ReadLine());
        int secondInteger = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(firstInteger, secondInteger));
    }

    /// <summary>
    /// A method GetMax() with two parameters that returns the larger of two integers. 
    /// </summary>
    /// <param name="firstInteger">first integer</param>
    /// <param name="secondInteger">second integer</param>
    /// <returns>the larger of two integers</returns>
    public static int GetMax(int firstInteger, int secondInteger)
    {
        int biggerNumber;

        if (firstInteger > secondInteger)
        {
            biggerNumber = firstInteger;
        }
        else
        {
            biggerNumber = secondInteger;
        }
        return biggerNumber;
    }
}

