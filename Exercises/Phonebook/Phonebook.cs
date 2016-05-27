namespace Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            FillThePhonebook(phonebook);
            SearchInPhonebook(phonebook);
        }

        private static void FillThePhonebook(Dictionary<string, string> phonebook)
        {
            string line = Console.ReadLine();
            while (line != "search")
            {
                string[] splitInfo = line.Split('-');
                string name = splitInfo[0];
                string phone = splitInfo[1];

                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = phone;
                }
                else
                {
                    phonebook.Add(name, phone);
                }

                line = Console.ReadLine();
            }
        }

        private static void SearchInPhonebook(Dictionary<string, string> phonebook)
        {
            string seatchLine = Console.ReadLine();
            while (seatchLine != "stop")
            {
                if (phonebook.ContainsKey(seatchLine))
                {
                    Console.WriteLine($"{seatchLine} -> {phonebook[seatchLine]}");
                }
                else
                {
                    Console.WriteLine($"Contact {seatchLine} does not exist.");
                }

                seatchLine = Console.ReadLine();
            }
        }
    }
}
