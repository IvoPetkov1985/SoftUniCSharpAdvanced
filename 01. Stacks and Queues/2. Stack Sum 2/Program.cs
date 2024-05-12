using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Stack_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(numArray);

            string commandLine = Console.ReadLine().ToLower();

            while (commandLine != "end")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);
                    numbers.Push(firstNum);
                    numbers.Push(secondNum);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(tokens[1]);

                    if (count <= numbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                commandLine = Console.ReadLine().ToLower();
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
