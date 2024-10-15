using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numbers = numbers.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
