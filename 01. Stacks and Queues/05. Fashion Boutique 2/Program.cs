using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothes = new Stack<int>(values);

            int rackCapacity = int.Parse(Console.ReadLine());
            int numberOfRacks = 1;
            int sum = 0;

            while (clothes.Any())
            {
                sum += clothes.Peek();

                if (sum <= rackCapacity)
                {
                    clothes.Pop();
                }
                else
                {
                    numberOfRacks++;
                    sum = 0;
                }
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}
