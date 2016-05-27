using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());

            HashSet<string> uniqueUserNames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                uniqueUserNames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", uniqueUserNames));
        }
    }
}
