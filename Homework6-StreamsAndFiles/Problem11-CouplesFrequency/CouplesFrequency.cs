using System;
using System.Collections.Generic;

public class CouplesFrequency
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] numArray = input.Split(' ');
    

        Dictionary<string, double> result = new Dictionary<string, double>();
        for (int i = 0; i < numArray.Length - 1; i++)
        {
            string substring = numArray[i] + " " + numArray[i + 1];
            double count = SearchCountOfSequence(numArray, substring);
            double procent = (count*100)/(numArray.Length - 1);
            if (!result.ContainsKey(substring))
            {
                result[substring] = procent;
            }
          
        }

        foreach (var pair in result)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value:F2}%");
        }
    }

    public static int SearchCountOfSequence(string[] numArray, string substring)
    {
        int countOfSequence = 0;
    
            for (int index = 0; index < numArray.Length - 1; index++)
            {
                string isEqualStr = numArray[index] + " " + numArray[index + 1];
                if (substring == isEqualStr)
                    {
                        countOfSequence++;
                    }
            }    
        
        return countOfSequence;
    }
}

