using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArr[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] *= 2;
                        jaggedArr[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArr[row + 1].Length; col++)
                    {
                        jaggedArr[row + 1][col] /= 2;
                    }
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= 0 && row < jaggedArr.Length
                    && col >= 0 && col < jaggedArr[row].Length)
                {
                    switch (command)
                    {
                        case "Add":
                            jaggedArr[row][col] += value;
                            break;

                        case "Subtract":
                            jaggedArr[row][col] -= value;
                            break;
                    }
                }

                commandLine = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int i = 0; i < jaggedArr[row].Length; i++)
                {
                    Console.Write(jaggedArr[row][i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
