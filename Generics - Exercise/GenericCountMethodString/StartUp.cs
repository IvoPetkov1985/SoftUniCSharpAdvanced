using System;

namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<string> stringCollection = new Box<string>();

            for (int i = 0; i < count; i++)
            {
                string currentItem = Console.ReadLine();
                stringCollection.AddElement(currentItem);
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(stringCollection.GreaterElements(itemToCompare));
        }
    }
}
