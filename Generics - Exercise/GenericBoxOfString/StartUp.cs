using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < count; i++)
            {
                string inputLine = Console.ReadLine();

                box.AddItem(inputLine);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
