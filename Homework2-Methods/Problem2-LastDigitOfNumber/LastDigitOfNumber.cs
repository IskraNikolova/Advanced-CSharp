using System;

public class LastDigitOfNumber
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitAsWord(number));
    }

    /// <summary>
    /// A method that returns the last digit of a given integer as an English word.
    /// </summary>
    /// <param name="number">input number</param>
    /// <returns>last digit as word</returns>
    public static string GetLastDigitAsWord(long number)
    {
        string lastDigit = (number%10).ToString();

        switch (lastDigit)
        {
            case "1":
                lastDigit = "one";
                break;
            case "2":
                lastDigit = "two";
                break;
            case "3":
                lastDigit = "three";
                break;
            case "4":
                lastDigit = "four";
                break;
            case "5":
                lastDigit = "five";
                break;
            case "6":
                lastDigit = "six";
                break;
            case "7":
                lastDigit = "seven";
                break;
            case "8":
                lastDigit = "eight";
                break;
            case "9":
                lastDigit = "nine";
                break;
        }
        return lastDigit;
    }
}

