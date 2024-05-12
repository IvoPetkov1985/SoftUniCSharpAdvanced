using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandInts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToEnqueue = commandInts[0];

            Queue<int> collection = new Queue<int>();

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                collection.Enqueue(elements[i]);
            }

            int elementsToDequeue = commandInts[1];

            for (int i = 0; i < elementsToDequeue; i++)
            {
                collection.Dequeue();
            }

            int searchedNum = commandInts[2];

            if (!collection.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                if (collection.Contains(searchedNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(collection.Min());
                }
            }
        }
    }
}
