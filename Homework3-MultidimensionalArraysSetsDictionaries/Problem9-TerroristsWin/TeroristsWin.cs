using System;
using System.Text;

public class TerroristsWin
{
    public static void Main()
    {
        string inputText = Console.ReadLine();

        StringBuilder resultAfterBomb = new StringBuilder(inputText);
        int firstIndex = inputText.IndexOf('|');

        int lastDigit = 0;
        int secondIndex = 0;
        while (firstIndex != -1)
        {
            int sum = 0;
            secondIndex = inputText.IndexOf('|', firstIndex + 1);
            for (int i = firstIndex + 1; i <= secondIndex - 1; i++)
            {
                sum += inputText[i];
            }

            lastDigit = sum%10;
            int destroidAreaFrom = firstIndex - lastDigit;
            int destroidAreaTo = secondIndex + lastDigit;
            for (int i = destroidAreaFrom; i <= destroidAreaTo; i++)
            {
                if (i >= 0 && i < resultAfterBomb.Length)
                {
                    resultAfterBomb[i] = '.';
                }
            }

            firstIndex = inputText.IndexOf('|', secondIndex + 1);
        }

        Console.WriteLine(resultAfterBomb);
    }
}

