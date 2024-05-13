using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueOfNums = new Queue<int>(numbers);

            List<int> result = new List<int>();

            foreach (int number in queueOfNums)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
