namespace Problem4_SequencesOfEqualStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SequencesOfEqualStrings
    {
        /// <summary>
        /// A program that reads an array of strings and finds in it all sequences of equal elements.
        /// </summary>
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var equalseGroups = new Dictionary<string, string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!equalseGroups.ContainsKey(input[i]))
                {
                    equalseGroups.Add(input[i], input[i]);
                }
                else
                {
                    equalseGroups[input[i]] += $" {input[i]}";
                }               
            }

            foreach (var element in equalseGroups)
            {
                Console.WriteLine(element.Value);
            }
        }
    }
}

