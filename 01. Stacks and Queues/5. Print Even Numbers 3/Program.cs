using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(numArray);

            Queue<int> selected = new Queue<int>();

            while (numbers.Any())
            {
                int num = numbers.Dequeue();

                if (num % 2 == 0)
                {
                    selected.Enqueue(num);
                }
            }

            Console.WriteLine(string.Join(", ", selected));
        }
    }
}
