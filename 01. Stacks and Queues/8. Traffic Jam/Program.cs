using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPassingCount = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            Queue<string> vehicles = new Queue<string>();
            int counter = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    vehicles.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < carsPassingCount; i++)
                    {
                        if (vehicles.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{vehicles.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
