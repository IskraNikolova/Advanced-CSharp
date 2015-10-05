using System;
using System.Collections.Generic;

public class OfficeStuff
{
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        var listOfCompany = new SortedDictionary<string, string>();
        for (int i = 0; i < input; i++)
        {
            string[] inputText = Console.ReadLine().Split('-');
            string companyNames = inputText[0].Substring(1, inputText[0].Length - 2);
            string amount = inputText[1].Trim();
            string product = inputText[2].Substring(1, inputText[2].Length - 2);
            string result = $"{product}-{amount}";

            if (listOfCompany.ContainsKey(companyNames))
            {
                if (result.Split('-')[0] == listOfCompany[companyNames].Split('-')[0])
                {
                    int amountPart1 = int.Parse(result.Split('-')[1]);
                    int amountPart2 = int.Parse(listOfCompany[companyNames].Split('-')[1]);
                    int sum = amountPart2 + amountPart1;
                    string resultAfterSum = result.Split('-')[0] + '-' + sum;
                    listOfCompany[companyNames] = resultAfterSum;
                }
                else
                {
                    listOfCompany[companyNames] += ", " + result;
                }
            }
            else
            {
                listOfCompany.Add(companyNames, result);
            }
        }

        foreach (var company in listOfCompany)
        {
            Console.WriteLine($"{company.Key}: {company.Value}");
        }
    }
}

