using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SrybskoUnleashed
{
    public class SrybskoUnleashed
    {
        public static void Main()
        {
            var venues = new Dictionary<string, Dictionary<string, int>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                string pattern = @"([A-Za-z\s]+)\s\@([A-Za-z\s]+)\s(\d+)\s(\d+)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(inputLine);
                Match matched = regex.Match(inputLine);
                bool isMatch = matched.Success;
                if (isMatch)
                {
                    string singer = string.Empty;
                    string venue = string.Empty;
                    int price = 0;
                    int count = 0;
                    foreach (Match match in matches)
                    {
                        singer = match.Groups[1].Value;
                        venue = match.Groups[2].Value;
                        price = int.Parse(match.Groups[3].Value);
                        count = int.Parse(match.Groups[4].Value);
                    }

                    int tottalMoney = price * count;

                    if (!venues.ContainsKey(venue))
                    {
                        venues.Add(venue, new Dictionary<string, int>());
                    }

                    if (!venues[venue].ContainsKey(singer))
                    {
                        venues[venue][singer] = 0;
                    }

                    venues[venue][singer] += tottalMoney;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var pair in venues)
            {
                Console.WriteLine($"{pair.Key}");
                var ordered = pair.Value.OrderByDescending(s => s.Value);
                foreach (var innerPair in ordered)
                {
                    Console.WriteLine($"#  {innerPair.Key} -> {innerPair.Value}");
                }
            }
        }
    }
}

