using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] instructions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsCount = instructions[0];
            int elementsToPop = instructions[1];
            int searchedElement = instructions[2];

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementsCount; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }

            if (!stack.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(searchedElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minimalValue = stack.Min();
                    Console.WriteLine(minimalValue);
                }
            }
        }
    }
}
