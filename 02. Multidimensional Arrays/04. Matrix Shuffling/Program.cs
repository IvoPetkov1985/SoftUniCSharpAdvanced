using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions.First();
            int cols = dimensions.Last();

            string[,] textMatrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    textMatrix[row, col] = array[col];
                }
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "END")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "swap" && tokens.Length == 5
                    && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
                    && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
                    && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
                    && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols)
                {
                    int row1 = int.Parse(tokens[1]);
                    int col1 = int.Parse(tokens[2]);
                    int row2 = int.Parse(tokens[3]);
                    int col2 = int.Parse(tokens[4]);

                    string buff = textMatrix[row1, col1];
                    textMatrix[row1, col1] = textMatrix[row2, col2];
                    textMatrix[row2, col2] = buff;

                    for (int row = 0; row < textMatrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < textMatrix.GetLength(1); col++)
                        {
                            Console.Write(textMatrix[row, col] + " ");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                commandLine = Console.ReadLine();
            }
        }
    }
}
