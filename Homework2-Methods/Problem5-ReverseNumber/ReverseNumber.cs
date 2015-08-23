using System;
using System.Text;

public class ReverseNumber
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(number);

        Console.WriteLine(reversed);
    }
    /// <summary>
    /// A method that reverses the digits of a given floating-point number.
    /// </summary>
    /// <param name="number">number to reverse</param>
    /// <returns>reversed number</returns>
    public static double GetReversedNumber(double number)
    {
        double reversedNumber = number;
        string reverse = reversedNumber.ToString();

        StringBuilder builderReverse = new StringBuilder();
        for (int i = reverse.Length - 1; i >= 0; i--)
        {
            builderReverse.Append(reverse[i]);
        }

        reversedNumber = double.Parse(builderReverse.ToString());

        return reversedNumber;
    }
}

