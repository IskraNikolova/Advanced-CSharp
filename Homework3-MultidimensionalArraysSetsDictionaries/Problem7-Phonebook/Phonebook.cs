namespace Problem7_Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "search")
            {
                FillThePhonebook(input, phonebook);

                input = Console.ReadLine();
            }

            string searchContact = Console.ReadLine();
            while (searchContact != string.Empty)
            {
                PrintResultOfSearch(phonebook, searchContact);

                searchContact = Console.ReadLine();
            }
        }

        private static void PrintResultOfSearch(Dictionary<string, string> phonebook, string searchContact)
        {
            if (phonebook.ContainsKey(searchContact))
            {
                Console.Write("{0} -> {1}", searchContact, string.Join(", ", phonebook[searchContact]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchContact);
            }
        }

        private static void FillThePhonebook(string input, Dictionary<string, string> phonebook)
        {
            string name = input.Split('-')[0];
            string tel = input.Split('-')[1];
            if (phonebook.ContainsKey(name))
            {
                phonebook[name] += $"; {tel}";
            }
            else
            {
                phonebook.Add(name, tel);
            }
        }
    }
}

