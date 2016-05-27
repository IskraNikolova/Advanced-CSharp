using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            string line = Console.ReadLine().ToLower();
            var materials = new Dictionary<string, int>();
            materials.Add("fragments", 0);
            materials.Add("motes", 0);
            materials.Add("shards", 0);

            var junks = new SortedDictionary<string, int>();
            while (true)
            {
                string[] data = line.Split();
                int quantity = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if (i%2 == 0)
                    {
                        quantity = int.Parse(data[i]);
                    }
                    else
                    {
                        var material = data[i];
                        if (material == "fragments" || material == "motes" || material == "shards")
                        {                
                            materials[material] += quantity;
                            if (materials[material] >= 250)
                            {
                                materials[material] -= 250;
                                PrintResult(materials, junks, material);
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            if (!junks.ContainsKey(material))
                            {
                                junks.Add(material, 0);
                            }

                            junks[material] += quantity;
                        }
                    }
                }

                line = Console.ReadLine().ToLower();
            }
        }

        private static void PrintResult(Dictionary<string, int> materials, SortedDictionary<string, int> junks, string material)
        {
           string name = string.Empty;
            switch (material)
            {
                case "shards":
                    name = "Shadowmourne";
                    break;
                case "motes":
                    name = "Dragonwrath";
                    break;
                case "fragments":
                    name = "Valanyr";
                    break;
            }

            Console.WriteLine($"{name} obtained!");

            var orderedMaterials = materials.OrderByDescending(m => m.Value).ThenBy(m => m.Key);
            foreach (var m in orderedMaterials)
            {
                Console.WriteLine($"{m.Key}: {m.Value}");
            }

            foreach (var junk in junks)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
