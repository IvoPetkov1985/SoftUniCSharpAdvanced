using System;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<double> boxCollection = new Box<double>();

            for (int i = 0; i < count; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                boxCollection.AddItem(currentNum);
            }

            double numToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(boxCollection.GreaterItemsCount(numToCompare));
        }
    }
}
