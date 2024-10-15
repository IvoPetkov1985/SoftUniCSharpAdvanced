using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            HashSet<string> allCars = new HashSet<string>();

            while (inputLine != "END")
            {
                string[] tokens = inputLine
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = tokens[0];
                string carNumber = tokens[1];

                switch (direction)
                {
                    case "IN":
                        allCars.Add(carNumber);
                        break;

                    case "OUT":
                        allCars.Remove(carNumber);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            if (!allCars.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string car in allCars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
