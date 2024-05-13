using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Supermarket_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Queue<string> waiting = new Queue<string>();

            while (line != "End")
            {
                if (line == "Paid")
                {
                    while (waiting.Any())
                    {
                        string name = waiting.Dequeue();
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    waiting.Enqueue(line);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"{waiting.Count} people remaining.");
        }
    }
}
