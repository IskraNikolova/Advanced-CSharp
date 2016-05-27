using System;
using System.Collections.Generic;

namespace LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());
            var userIpCollection = new SortedDictionary<string, SortedSet<string>>();
            var userAmountOfHour = new SortedDictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string ip = data[0];
                string user = data[1];
                int duration = int.Parse(data[2]);

                if (!userIpCollection.ContainsKey(user))
                {
                    userIpCollection.Add(user, new SortedSet<string>());
                }

                userIpCollection[user].Add(ip);

                if (!userAmountOfHour.ContainsKey(user))
                {
                    userAmountOfHour.Add(user, 0);
                }

                userAmountOfHour[user] += duration;
            }

            foreach (var user in userIpCollection)
            {
                Console.WriteLine($"{user.Key}: {userAmountOfHour[user.Key]} [{string.Join(", ", user.Value)}]");
            }
        }
    }
}
