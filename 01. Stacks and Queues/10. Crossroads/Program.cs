using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> carsQueue = new Queue<string>();
            int counter = 0;

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command != "green")
                {
                    string car = command;
                    carsQueue.Enqueue(car);
                }
                else
                {
                    int seconds = greenLightDuration;
                    int addedSeconds = freeWindowDuration;

                    while (carsQueue.Any() && seconds > 0)
                    {
                        string passingCar = carsQueue.Dequeue();

                        if (seconds - passingCar.Length >= 0)
                        {
                            seconds -= passingCar.Length;
                            counter++;
                            continue;
                        }

                        if (seconds + addedSeconds - passingCar.Length >= 0)
                        {
                            counter++;
                            continue;
                        }

                        int hitIndex = seconds + addedSeconds;

                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{passingCar} was hit at {passingCar[hitIndex]}.");
                        return;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
