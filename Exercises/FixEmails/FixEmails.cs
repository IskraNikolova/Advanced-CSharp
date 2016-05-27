using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            string commandLine = Console.ReadLine();
            Dictionary<string, string> result = new Dictionary<string, string>();
            int countOfLine = 0;
            string name = string.Empty;
            string email = string.Empty;
            while (commandLine != "stop")
            {
                if (countOfLine % 2 == 0)
                {
                    name = commandLine;
                    if (!result.ContainsKey(name))
                    {
                        result.Add(name, string.Empty);
                    }
                }
                else
                {
                    email = commandLine;
                    result[name] = email;
                }

                countOfLine++;
                commandLine = Console.ReadLine();
            }

            var fixEmailCollection = result.Where(u => !(u.Value.EndsWith("us") || u.Value.EndsWith("uk")));
            foreach (var line in fixEmailCollection)
            {
                Console.WriteLine($"{line.Key} -> {line.Value}");
            }
        }
    }
}
