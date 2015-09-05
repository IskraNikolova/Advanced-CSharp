using System;
using System.Collections.Generic;
using System.Linq;

public class ActivityTracker
{
    public static void Main()
    {
        int countOfDateLines = int.Parse(Console.ReadLine());

    
        var list = new SortedDictionary<string, SortedDictionary<string, int>>();
        for (int i = 0; i < countOfDateLines; i++)
        {
            string input = Console.ReadLine();
            if (input != null)
            {
                string month = input.Split(' ')[0].Substring(3, 2);
                if (month[0] == '0')
                {
                    month = month[1].ToString();
                }

                string name = input.Split(' ')[1];
                int meter = int.Parse(input.Split(' ')[2]);

                if (!list.ContainsKey(month))
                {
                    list[month] = new SortedDictionary<string, int>();
                }
                if (!list[month].ContainsKey(name))
                {
                    list[month][name] = meter;
                }
                else
                {
                    list[month][name] += meter;
                }
            }
        }
     
        List<string> result = new List<string>();
        foreach (var month in list)
        {
            Console.Write("{0}: ", month.Key);
            result.AddRange(month.Value.Select(name => $"{name.Key}({name.Value})"));

            Console.WriteLine(string.Join(", ", result));
            result.Clear();
        }

    }
}

