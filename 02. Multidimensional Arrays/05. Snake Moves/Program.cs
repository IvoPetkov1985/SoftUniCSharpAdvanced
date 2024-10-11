using System;
using System.Linq;

namespace _05._Snake_Moves
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

            char[,] matrix = new char[rows, cols];

            string text = Console.ReadLine();
            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[row, col] = text[index];
                    }
                    else
                    {
                        matrix[row, cols - 1 - col] = text[index];
                    }

                    index++;

                    if (index == text.Length)
                    {
                        index = 0;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
