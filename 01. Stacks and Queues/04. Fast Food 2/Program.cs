using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> clients = new Queue<int>(numbers);
            bool isFoodEnough = true;

            int biggestOrder = clients.Max();
            Console.WriteLine(biggestOrder);

            int food = quantityOfFood;

            while (clients.Any())
            {
                int order = clients.Peek();

                if (order <= food)
                {
                    food -= order;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", clients)}");
                    isFoodEnough = false;
                    break;
                }

                clients.Dequeue();
            }

            if (isFoodEnough)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
