using System;
using System.Linq;

public class LettersChangeNumbers
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        double sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int length = input[i].Length - 1;
            char firstChar = input[i][0];
            char lastChar = input[i][length];
            string number = input[i].Substring(1, length - 1);
            double num = double.Parse(number);
            double resultAfterFirstOp = 0;
            if (char.IsUpper(firstChar))
            {
                double divide = num / (char.ToLower(firstChar) - 96);
                resultAfterFirstOp = divide;
            }
            if (char.IsLower(firstChar))
            {
                double multiply = num * (char.ToLower(firstChar) - 96);
                resultAfterFirstOp = multiply;
            }
            if (char.IsUpper(lastChar))
            {
                double subtract = resultAfterFirstOp - (char.ToLower(lastChar) - 96);
                sum += subtract;
            }
            if (char.IsLower(lastChar))
            {
                double add = resultAfterFirstOp + (char.ToLower(lastChar) - 96);
                sum += add;
            }
        }

        Console.WriteLine("{0:F2}", sum);
    }
}

