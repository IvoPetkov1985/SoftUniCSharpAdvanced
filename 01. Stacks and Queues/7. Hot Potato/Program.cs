using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> kids = new Queue<string>(names);

            int tosses = int.Parse(Console.ReadLine());

            while (kids.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }

                string kidToDequeue = kids.Dequeue();
                Console.WriteLine($"Removed {kidToDequeue}");
            }

            string lastKid = kids.Peek();
            Console.WriteLine($"Last is {lastKid}");
        }
    }
}
