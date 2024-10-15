using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            SortedDictionary<char, int> occurrences = new SortedDictionary<char, int>();

            foreach (char letter in inputLine)
            {
                if (!occurrences.ContainsKey(letter))
                {
                    occurrences.Add(letter, 0);
                }

                occurrences[letter]++;
            }

            foreach (KeyValuePair<char, int> kvp in occurrences)
            {
                char symbol = kvp.Key;
                int times = kvp.Value;

                Console.WriteLine($"{symbol}: {times} time/s");
            }
        }
    }
}
