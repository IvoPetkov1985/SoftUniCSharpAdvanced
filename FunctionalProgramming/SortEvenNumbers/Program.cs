using System;
using System.Linq;

namespace SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);
            Predicate<int> isEven = x => x % 2 == 0;

            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Where(x => isEven(x))
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
