using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int queriesCount = int.Parse(Console.ReadLine());

            Stack<int> collection = new Stack<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                int[] queryDetails = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int commandNum = queryDetails.First();

                switch (commandNum)
                {
                    case 1:

                        int numToPush = queryDetails.Last();
                        collection.Push(numToPush);
                        break;

                    case 2:

                        collection.Pop();
                        break;

                    case 3:

                        if (collection.Any())
                        {
                            int maxNum = collection.Max();
                            Console.WriteLine(maxNum);
                        }
                        break;

                    case 4:

                        if (collection.Any())
                        {
                            int minNum = collection.Min();
                            Console.WriteLine(minNum);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
