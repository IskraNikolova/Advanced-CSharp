using System;
using System.Linq;


//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. 
//Overload the methods to work with numbers of type double and decimal.

public class NumberCalculations
{
    public static void Main()
    {
        double[] setOfNumber = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();


        decimal[] setOfDecimal = new decimal[setOfNumber.Length];
        for (int i = 0; i < setOfDecimal.Length; i++)
        {
            setOfDecimal[i] = (decimal)setOfNumber[i];
        }

        Console.WriteLine(CalculateMinNumber(setOfNumber));
        Console.WriteLine(CalculateMinNumber(setOfDecimal));

        Console.WriteLine(CalculateMaxNumber(setOfNumber));
        Console.WriteLine(CalculateMaxNumber(setOfDecimal));

        Console.WriteLine(CalculateAvarage(setOfNumber));
        Console.WriteLine(CalculateAvarage(setOfDecimal));

        Console.WriteLine(CalculateSum(setOfNumber));
        Console.WriteLine(CalculateSum(setOfDecimal));

        Console.WriteLine(CalculateProduct(setOfNumber));
        Console.WriteLine(CalculateProduct(setOfDecimal));

    }

    public static double CalculateMinNumber(double[] setOfNumber)
    {
        double minNumber = setOfNumber[0];
        for (int i = 0; i < setOfNumber.Length; i++)
        {
            if (minNumber > setOfNumber[i])
            {
                minNumber = setOfNumber[i];
            }
        }

        return minNumber;
    }

    public static double CalculateMaxNumber(double[] setOfNumber)
    {
        double maxNumber = 0;
        for (int i = 0; i < setOfNumber.Length; i++)
        {
            if (setOfNumber[i] > maxNumber)
            {
                maxNumber = setOfNumber[i];
            }
        }

        return maxNumber;
    }

    public static double CalculateAvarage(double[] setOfNumbers)
    {
        double sum = 0;
        int count = setOfNumbers.Length;

        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            sum += setOfNumbers[i];
        }

        double avarage = sum/count;

        return avarage;
    }


    public static double CalculateSum(double[] setOfNumbers)
    {
        double sum = 0;
       
        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            sum += setOfNumbers[i];
        }

        return sum;
    }

    public static double CalculateProduct(double[] setOfNumbers)
    {
        double product = 1;

        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            product *= setOfNumbers[i];
        }

        return product;
    }

    public static decimal CalculateMinNumber(decimal[] setOfNumber)
    {
        decimal minNumber = setOfNumber[0];
        for (int i = 0; i < setOfNumber.Length; i++)
        {
            if (minNumber > setOfNumber[i])
            {
                minNumber = setOfNumber[i];
            }
        }

        return minNumber;
    }

    public static decimal CalculateMaxNumber(decimal[] setOfNumber)
    {
        decimal maxNumber = 0;
        for (int i = 0; i < setOfNumber.Length; i++)
        {
            if (setOfNumber[i] > maxNumber)
            {
                maxNumber = setOfNumber[i];
            }
        }

        return maxNumber;
    }

    public static decimal CalculateAvarage(decimal[] setOfNumbers)
    {
        decimal sum = 0;
        int count = setOfNumbers.Length;

        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            sum += setOfNumbers[i];
        }

        decimal avarage = sum / count;

        return avarage;
    }


    public static decimal CalculateSum(decimal[] setOfNumbers)
    {
        decimal sum = 0;

        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            sum += setOfNumbers[i];
        }

        return sum;
    }

    public static decimal CalculateProduct(decimal[] setOfNumbers)
    {
        decimal product = 1;

        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            product *= setOfNumbers[i];
        }

        return product;
    }
}

