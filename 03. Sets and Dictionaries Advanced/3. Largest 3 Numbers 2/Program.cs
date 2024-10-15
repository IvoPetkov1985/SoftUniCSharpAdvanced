using System;
using System.Linq;

namespace _3._Largest_3_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers);

            numbers = numbers.Reverse().Take(3).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
