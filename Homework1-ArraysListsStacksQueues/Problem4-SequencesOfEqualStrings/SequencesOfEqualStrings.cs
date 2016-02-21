namespace Problem4_SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
 
    public class SequencesOfEqualStrings
    {
        /// <summary>
        /// A program that reads an array of strings and finds in it all sequences of equal elements.
        /// </summary>
        public static void Main()
        {
            var input = ReadInputData();

            var equalseGroups = new Dictionary<string, string>();

            OrderEqualsElementsInGroupByDictionary(input, equalseGroups);

            PrintEqualsElement(equalseGroups);
        }

        public static string[] ReadInputData()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            return input;
        }

        public static void OrderEqualsElementsInGroupByDictionary(string[] input, Dictionary<string, string> equalseGroups)
        {
            if (input.Length == 0)
            {
                throw new ArgumentNullException(nameof(input), "Input data can not be null."); 
            }

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
        }

        private static void PrintEqualsElement(Dictionary<string, string> equalseGroups)
        {
            foreach (var element in equalseGroups)
            {
                Console.WriteLine(element.Value);
            }
        }
    }
}
