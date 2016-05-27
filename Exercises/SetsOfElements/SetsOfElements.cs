using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            int[] countsOfSets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();
            for (int i = 0; i < countsOfSets[0]; i++)
            {
                n.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i <countsOfSets[1]; i++)
            {
                m.Add(int.Parse(Console.ReadLine()));
            }

            string result = string.Empty;
            foreach (var elementOfN in n)
            {
                if (m.Contains(elementOfN))
                {
                    result += elementOfN + " ";
                }
            }

            Console.WriteLine(result.Trim());
        }
    }
}
