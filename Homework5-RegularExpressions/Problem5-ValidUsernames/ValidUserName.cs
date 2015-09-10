using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ValidUserName
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new []{' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

        int minLength = 3;
        int maxLength = 25;
        List<string> validUserName = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            string pattern = @"\b([A-Z]|[a-z]\w+)";
            Regex regex = new Regex(pattern);
            bool isUserName = regex.IsMatch(input[i]);
            if (isUserName)
            {
                if (input[i].Length > minLength && input[i].Length < maxLength)
                {
                    validUserName.Add(input[i]);
                }
              
            }
        }

        int biggestSum = 0;
        string firstUserName = string.Empty;
        string secondUserName = string.Empty;
        for (int i = 0; i < validUserName.Count - 1; i++)
        {
            if (validUserName[i].Length + validUserName[i + 1].Length > biggestSum)
            {
                biggestSum = validUserName[i].Length + validUserName[i + 1].Length;
                firstUserName = validUserName[i];
                secondUserName = validUserName[i + 1];
            }
        }
        Console.WriteLine("{0}\n{1}", firstUserName, secondUserName);
    }

}

