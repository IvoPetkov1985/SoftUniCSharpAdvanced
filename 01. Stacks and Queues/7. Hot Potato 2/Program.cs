using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Hot_Potato_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] tokens = inputLine
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> kids = new Queue<string>(tokens);

            int tosses = int.Parse(Console.ReadLine());

            while (kids.Count > 1)
            {
                for (int i = 0; i < tosses - 1; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }

                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
