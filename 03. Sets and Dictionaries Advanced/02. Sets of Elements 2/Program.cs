using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Sets_of_Elements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstCount = dimensions.First();
            int secondCount = dimensions.Last();

            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();

            for (int i = 0; i < firstCount; i++)
            {
                setOne.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < secondCount; i++)
            {
                setTwo.Add(int.Parse(Console.ReadLine()));
            }

            setOne.IntersectWith(setTwo);

            Console.WriteLine(string.Join(" ", setOne));
        }
    }
}
