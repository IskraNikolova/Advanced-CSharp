using System;
using System.Collections.Generic;
using System.Linq;

class OfficeStuff
{
    static void Main()
    {
       
        var companyOrders = new SortedDictionary<string, Dictionary<string, int>>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] order = Console.ReadLine().Split(new char[] { '|', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            FillDictionary(order, companyOrders);
        }
        Print(companyOrders);
    }

    private static void Print(SortedDictionary<string, Dictionary<string, int>> companyOrders)
    {
        List<string> result = new List<string>();

        foreach (var pair1 in companyOrders)
        {
            Console.Write($"{pair1.Key}: ");
            result.AddRange(pair1.Value.Select(pair2 => String.Format("{0}-{1}", pair2.Key, pair2.Value)));
            Console.WriteLine(string.Join(", ", result));
            result.Clear();
        }
    }

    private static void FillDictionary(string[] order, SortedDictionary<string, Dictionary<string, int>> companyOrders)
    {
        string company = order[0];
        string product = order[2];
        int amount = int.Parse(order[1]);

        if (!companyOrders.ContainsKey(company))
        {
            var products = new Dictionary<string, int>();
            products.Add(product, 0);
            companyOrders.Add(company, products);
        }
        else if (!companyOrders[company].ContainsKey(product))
        {
            companyOrders[company].Add(product, 0);
        }
        companyOrders[company][product] += amount;
    }
}

