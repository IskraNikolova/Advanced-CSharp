using System;
using System.Collections.Generic;

public class NightLife
{
    public static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> list =
            new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        while (true)
        {
            string input = Console.ReadLine();

            if (input != "END")
            {
                string city = input.Split(';')[0];
                string even = input.Split(';')[1];
                string artist = input.Split(';')[2];
                if (!list.ContainsKey(city))
                {
                    list[city] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!list[city].ContainsKey(even))
                {
                    list[city][even] = new SortedSet<string>();
                }

                list[city][even].Add(artist);
            }
            else
            {
                break;
            }
        }

        foreach (var city in list)
        {
            Console.WriteLine(city.Key);
            foreach (var even in city.Value)
            {
                Console.WriteLine("->{0}: {1}", even.Key, String.Join(", ", even.Value));
            }
        }
    }
}

