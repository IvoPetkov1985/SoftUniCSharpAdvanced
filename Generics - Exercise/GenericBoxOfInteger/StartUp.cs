using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<int> boxCollection = new Box<int>();

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                boxCollection.AddElement(currentNum);
            }

            Console.WriteLine(boxCollection.ToString());
        }
    }
}
