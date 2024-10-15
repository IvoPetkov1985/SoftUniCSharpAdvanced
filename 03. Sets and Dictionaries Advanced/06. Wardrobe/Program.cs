using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string inputLine = Console.ReadLine();

                string[] tokens = inputLine
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string item in tokens.Skip(1))
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }

                    wardrobe[color][item]++;
                }
            }

            string searchedInput = Console.ReadLine();
            string[] searchedDetails = searchedInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = searchedDetails[0];
            string searchedPiece = searchedDetails[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (KeyValuePair<string, int> clothing in kvp.Value)
                {
                    if (kvp.Key == searchedColor && clothing.Key == searchedPiece)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
