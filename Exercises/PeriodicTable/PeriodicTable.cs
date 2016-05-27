using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());
            HashSet<string> tableOfUniqueElement = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < line.Length; j++)
                {
                    tableOfUniqueElement.Add(line[j]);
                }
            }

            Console.WriteLine(string.Join(" ", tableOfUniqueElement));
        }
    }
}
