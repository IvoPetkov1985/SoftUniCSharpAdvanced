using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
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

            int elementsToPush = commandInts[0];

            Stack<int> stackOfNums = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stackOfNums.Push(elements[i]);
            }

            int elementsToPop = commandInts[1];

            for (int i = 0; i < elementsToPop; i++)
            {
                stackOfNums.Pop();
            }

            int searchedNum = commandInts[2];

            if (stackOfNums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stackOfNums.Contains(searchedNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stackOfNums.Min());
                }
            }
        }
    }
}
