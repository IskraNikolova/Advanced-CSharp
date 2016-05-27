using System;
using System.Collections.Generic;

namespace CountSymbols
{
    public class CountSymbol
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> result = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (result.ContainsKey(input[i]))
                {
                    result[input[i]]++;
                }
                else
                {
                    result.Add(input[i], 1);
                }
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
