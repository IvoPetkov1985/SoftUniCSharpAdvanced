using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Traffic_Jam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int carCounter = default;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsCount; i++)
                    {
                        if (!cars.Any())
                        {
                            break;
                        }

                        string carPassing = cars.Dequeue();
                        carCounter++;
                        Console.WriteLine($"{carPassing} passed!");
                    }
                }
                else
                {
                    string carModel = command;
                    cars.Enqueue(carModel);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{carCounter} cars passed the crossroads.");
        }
    }
}
