using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, double>> allShops = new SortedDictionary<string, Dictionary<string, double>>();

            while (inputLine != "Revision")
            {
                string[] tokens = inputLine
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!allShops.ContainsKey(shop))
                {
                    allShops.Add(shop, new Dictionary<string, double>());
                }

                if (!allShops[shop].ContainsKey(product))
                {
                    allShops[shop].Add(product, price);
                }

                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, double>> kvp in allShops)
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (KeyValuePair<string, double> productInfo in kvp.Value)
                {
                    Console.WriteLine($"Product: {productInfo.Key}, Price: {productInfo.Value}");
                }
            }
        }
    }
}
