using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                chemicalElements.UnionWith(elements);
            }

            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}
