using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<int> boxCollection = new Box<int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                boxCollection.AddItem(number);
            }

            int[] inputIndices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = inputIndices.First();
            int secondIndex = inputIndices.Last();

            boxCollection.SwapItems(firstIndex, secondIndex);

            Console.WriteLine(boxCollection.ToString());
        }
    }
}
