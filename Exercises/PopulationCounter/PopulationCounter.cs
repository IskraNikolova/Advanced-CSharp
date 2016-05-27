using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            string inputData = Console.ReadLine();

            var populationData = new Dictionary<string, Dictionary<string, long>>();
            while (inputData != "report")
            {
                string[] dataToArray = inputData.Split('|');
                string city = dataToArray[0];
                string country = dataToArray[1];
                long population = long.Parse(dataToArray[2]);

                if (!populationData.ContainsKey(country))
                {
                    populationData.Add(country, new Dictionary<string, long>());
                }

                populationData[country].Add(city, population);

                inputData = Console.ReadLine();
            }

            var sortedPopulationData = populationData
                .OrderByDescending(x => x.Value
                    .Sum(y => y.Value));

            foreach (var countryInfo in sortedPopulationData)
            {
                long totalPopulation = countryInfo.Value.Sum(x => x.Value);
                Console.WriteLine(
                    "{0} (total population: {1})",
                    countryInfo.Key,
                    totalPopulation);

                var orderedCityData = countryInfo.Value
                    .OrderByDescending(x => x.Value);

                foreach (var cityInfo in orderedCityData)
                {
                    Console.WriteLine("=>{0}: {1}", cityInfo.Key, cityInfo.Value);
                }
            }
        }
    }
}
