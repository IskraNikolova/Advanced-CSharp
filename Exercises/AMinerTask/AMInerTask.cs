using System;
using System.Collections.Generic;

namespace AMinerTask
{
    public class AMInerTask
    {
        public static void Main()
        {
            string commandLine = Console.ReadLine();
            Dictionary<string, long> miner = new Dictionary<string, long>();
            int countOfLine = 0;
            string resource = string.Empty;
            long quantity = 0;
            while (commandLine != "stop")
            {
                if (countOfLine%2 == 0)
                {
                    resource = commandLine;
                    if (!miner.ContainsKey(resource))
                    {
                        miner.Add(resource, 0);
                    }
                }
                else
                {
                    quantity = long.Parse(commandLine);
                    miner[resource] += quantity;
                }

                countOfLine++;
                commandLine = Console.ReadLine();
            }

            foreach (var line in miner)
            {
                Console.WriteLine($"{line.Key} -> {line.Value}");
            }
        }
    }
}
