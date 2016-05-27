using System.Linq;

namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;

    public class HandsOfCards
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();
            while (inputLine != "JOKER")
            {
                string[] data = inputLine.Split(':');

                HashSet<string> cards = TakeCards(data[1]);
                string name = data[0];

                if (!result.ContainsKey(name))
                {
                    result.Add(name, new HashSet<string>());
                }

                foreach (var card in cards)
                {
                    result[name].Add(card);
                }

                inputLine = Console.ReadLine();
            }

            PrintResult(result);
        }

        private static void PrintResult(Dictionary<string, HashSet<string>> result)
        {

            foreach (var pair in result)
            {
                int resultValue = TakeAmountOfCards(pair.Value);
                Console.WriteLine($"{pair.Key}: {resultValue}");
            }
        }

        private static int TakeAmountOfCards(HashSet<string> cards)
        {
            int amount = 0;
            int firstMultiplier = 0;
            int secondMultiplier = 0;

            foreach (var card in cards)
            {
                string el = card.Substring(0, card.Length - 1);
                
                if (el == "J" || el == "Q" || el == "K" || el == "A")
                {
                    switch (el)
                    {
                        case "J":
                            firstMultiplier = 11;
                            break;
                        case "Q":
                            firstMultiplier = 12;
                            break;
                        case "K":
                            firstMultiplier = 13;
                            break;
                        case "A":
                            firstMultiplier = 14;
                            break;
                    }
                }
                else
                {
                    firstMultiplier = int.Parse(el);
                }

                string secondM = string.Empty;
                if (card.Length <= 2)
                {
                    secondM = card.Substring(el.Length, card.Length - 1);
                }
                else
                {
                    var take = card.Skip(2).Take(1);
                    secondM = string.Join("", take);
                }
              
                switch (secondM)
                {
                    case "S":
                        secondMultiplier = 4;
                        break;
                    case "H":
                        secondMultiplier = 3;
                        break;
                    case "D":
                        secondMultiplier = 2;
                        break;
                    case "C":
                        secondMultiplier = 1;
                        break;
                }

                amount += (firstMultiplier * secondMultiplier);
            }

            return amount;
        }

        private static HashSet<string> TakeCards(string collectionOfCards)
        {
            string[] arrayOfInput = collectionOfCards
                .Trim()
                .Split(',');

            HashSet<string> cards = new HashSet<string>();
            for (int i = 0; i < arrayOfInput.Length; i++)
            {
                cards.Add(arrayOfInput[i].Trim());
            }

            return cards;
        }
    }
}
