using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<string> boxCollection = new Box<string>();

            for (int i = 0; i < count; i++)
            {
                string currentItem = Console.ReadLine();
                boxCollection.AddElement(currentItem);
            }

            string commandLine = Console.ReadLine();

            int[] indices = commandLine
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indices.First();
            int secondIndex = indices.Last();

            boxCollection.SwapElements(firstIndex, secondIndex);

            Console.WriteLine(boxCollection.ToString());
        }
    }
}
