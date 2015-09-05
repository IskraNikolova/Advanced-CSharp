using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input != "search")
            {
              
                if (phonebook.ContainsKey(input.Split('-')[0]))
                {
                    phonebook[input.Split('-')[0]] += "; " + input.Split('-')[1];
                }
                else
                {
                    phonebook.Add(input.Split('-')[0], input.Split('-')[1]);
                }
              
            }
            else
            {
                break;
            }
         
        }
        string searchContact = " ";
        while (searchContact !=  "")
        {
            searchContact = Console.ReadLine();
           
            if (phonebook.ContainsKey(searchContact))
            {
                Console.Write("{0} -> {1}", searchContact, String.Join(", ", phonebook[searchContact]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchContact);
            }
            
        }
    }
}

