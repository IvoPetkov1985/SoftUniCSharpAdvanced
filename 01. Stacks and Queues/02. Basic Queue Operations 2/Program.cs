using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] instructions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int queueLength = instructions[0];
            int elementsToDrop = instructions[1];
            int searchedNumber = instructions[2];

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numsQueue = new Queue<int>();

            for (int i = 0; i < queueLength; i++)
            {
                numsQueue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToDrop; i++)
            {
                if (numsQueue.Any())
                {
                    numsQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (numsQueue.Any())
            {
                if (numsQueue.Contains(searchedNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minimalValue = numsQueue.Min();
                    Console.WriteLine(minimalValue);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
