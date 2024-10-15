using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            foreach (double num in numbers)
            {
                if (!occurrences.ContainsKey(num))
                {
                    occurrences.Add(num, 0);
                }

                occurrences[num]++;
            }

            foreach (KeyValuePair<double, int> count in occurrences)
            {
                Console.WriteLine($"{count.Key} - {count.Value} times");
            }
        }
    }
}
