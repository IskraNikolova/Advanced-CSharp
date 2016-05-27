namespace UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UserLogs
    {
        public static void Main()
        {
            string inputCommand = Console.ReadLine();
            var result = new SortedDictionary<string, Dictionary<string, int>>();
            while (inputCommand != "end")
            {
                string[] splitCommands = inputCommand.Split();
                string ip = splitCommands[0];
                string currentIp = TakeCurrentString(ip);
                string userName = splitCommands[2];
                string curentUserName = TakeCurrentString(userName);

                if (!result.ContainsKey(curentUserName))
                {
                    result.Add(curentUserName, new Dictionary<string, int>());
                }

                if (!result[curentUserName].ContainsKey(currentIp))
                {
                    result[curentUserName].Add(currentIp, 0);
                }

                result[curentUserName][currentIp]++;

                inputCommand = Console.ReadLine();
            }

            PrintResult(result);
        }

        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> result)
        {
            StringBuilder output = new StringBuilder();
            foreach (var pair in result)
            {
                output.AppendLine($"\n{pair.Key}:");
                foreach (var innerPair in pair.Value)
                {
                    output.Append($" {innerPair.Key} => {innerPair.Value},");
                }

                output.Remove(output.Length - 1, 1);
                output.Append(".");
            }

            Console.WriteLine(output.ToString().Trim());
        }

        private static string TakeCurrentString(string data)
        {
            string[] result = data.Split('=');

            return result[1];
        }
    }
}
