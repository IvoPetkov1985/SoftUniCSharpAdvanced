using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> allCities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string inputLine = Console.ReadLine();

                string[] tokens = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!allCities.ContainsKey(continent))
                {
                    allCities.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!allCities[continent].ContainsKey(country))
                {
                    allCities[continent].Add(country, new List<string>());
                }

                allCities[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> kvp in allCities)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (KeyValuePair<string, List<string>> details in kvp.Value)
                {
                    Console.Write($"  {details.Key} -> ");
                    Console.WriteLine(string.Join(", ", details.Value));
                }
            }
        }
    }
}
