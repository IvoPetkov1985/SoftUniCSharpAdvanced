using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int queriesCount = int.Parse(Console.ReadLine());

            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                int[] queryArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = queryArgs.First();

                if (command == 1)
                {
                    int value = queryArgs.Last();
                    elements.Push(value);
                }
                else if (command == 2)
                {
                    if (elements.Any())
                    {
                        elements.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (elements.Any())
                    {
                        Console.WriteLine(elements.Max());
                    }
                }
                else if (command == 4)
                {
                    if (elements.Any())
                    {
                        Console.WriteLine(elements.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
