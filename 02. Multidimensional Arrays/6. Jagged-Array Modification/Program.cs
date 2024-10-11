using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rowsCount][];

            for (int i = 0; i < rowsCount; i++)
            {
                jagged[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "END")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                {
                    if (command == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                commandLine = Console.ReadLine();
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
