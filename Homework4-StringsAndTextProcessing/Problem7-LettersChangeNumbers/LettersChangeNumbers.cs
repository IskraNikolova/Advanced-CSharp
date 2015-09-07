using System;
using System.Linq;
using System.Text.RegularExpressions;

public class LettersChangeNumbers
{
    public static void Main()
    {
      
        string[] input = Console.ReadLine().Split(' ').ToArray();

        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            double number = GetNumberOfString(input[i]);

            if (IsUpperFirstLetter(input[i]))
            {
                int divider = SearchPositionInAlphabetOfFirstLetter(input[i]);
                sum += (number/divider);

            }
            else
            {
                int multiplier = SearchPositionInAlphabetOfFirstLetter(input[i]);
                sum += (number * multiplier);
            }

            if (IsUpperLastLetter(input[i]))
            {
                int subtractNumber = SearchPositionInAlphabetOfLastLetter(input[i]);
                sum -= subtractNumber;

            }
            else
            {
                int addNumber = SearchPositionInAlphabetOfLastLetter(input[i]);
                sum += addNumber;
            }
        
        }
        Console.WriteLine("{0:F2}", sum);
    }

    static bool IsUpperFirstLetter(string input)
    {
        if (char.IsUpper(input[0]))
        {
            return true;
        }
        return false;
    }

    static bool IsUpperLastLetter(string input)
    {
        int lastIndex = input.Length - 1;
        if (char.IsUpper(input[lastIndex]))
        {
            return true;
        }
        return false;
    }

    static double GetNumberOfString(string input)
    {
        string pattern = @"(\d+)";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);
        double result = double.Parse(match.ToString());

        return result;
    }

    static int SearchPositionInAlphabetOfFirstLetter(string input)
    {
        char toLowerChar = char.ToLower(input[0]);
        int result = toLowerChar - 96;
        return result;
    }

    static int SearchPositionInAlphabetOfLastLetter(string input)
    {
        int lastIndex = input.Length - 1;
        char toLowerChar = char.ToLower(input[lastIndex]);
        int result = toLowerChar - 96;
        return result;
    }
}

