using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(values);

            int clothesOnTheRack = 0;
            int counter = 1;

            while (clothes.Any())
            {
                clothesOnTheRack += clothes.Peek();

                if (clothesOnTheRack <= rackCapacity)
                {
                    clothes.Pop();
                }
                else
                {
                    clothesOnTheRack = clothes.Pop();
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
