using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> names = new Queue<string>();

            while (command != "End")
            {
                if (command != "Paid")
                {
                    names.Enqueue(command);
                }
                else
                {
                    while (names.Any())
                    {
                        string currentName = names.Dequeue();
                        Console.WriteLine(currentName);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
