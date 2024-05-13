using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(inputNumbers);

            int biggestOrder = orders.Max();
            Console.WriteLine(biggestOrder);

            while (orders.Any())
            {
                foodQuantity -= orders.Peek();

                if (foodQuantity >= 0)
                {
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
