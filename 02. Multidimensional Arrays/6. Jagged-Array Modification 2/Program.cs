using System;
using System.Linq;

namespace _6._Jagged_Array_Modification_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[matrixRows][];

            for (int row = 0; row < matrixRows; row++)
            {
                jaggedArr[row] = Console.ReadLine()
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
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                commandLine = Console.ReadLine();
            }

            for (int row = 0; row < jaggedArr.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArr[row]));
            }
        }
    }
}
