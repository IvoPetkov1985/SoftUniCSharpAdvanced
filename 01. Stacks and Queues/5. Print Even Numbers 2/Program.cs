using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsCollection = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(numsCollection);

            string result = string.Empty;

            while (numbers.Any())
            {
                int currentNum = numbers.Dequeue();

                if (currentNum % 2 == 0)
                {
                    result += currentNum.ToString() + ", ";
                }
            }

            Console.WriteLine(result.TrimEnd(',', ' '));
        }
    }
}
