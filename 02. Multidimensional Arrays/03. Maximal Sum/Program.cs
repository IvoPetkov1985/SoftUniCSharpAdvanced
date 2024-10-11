using System;
using System.Linq;

namespace _03._Maximal_Sum
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

            int[,] numMatrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    numMatrix[row, col] = currentArray[col];
                }
            }

            int maxSum = int.MinValue;
            int startingRow = 0;
            int startingCol = 0;

            for (int row = 0; row < numMatrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < numMatrix.GetLength(1) - 2; col++)
                {
                    int currentSum = default;

                    currentSum += numMatrix[row, col] + numMatrix[row, col + 1] + numMatrix[row, col + 2];
                    currentSum += numMatrix[row + 1, col] + numMatrix[row + 1, col + 1] + numMatrix[row + 1, col + 2];
                    currentSum += numMatrix[row + 2, col] + numMatrix[row + 2, col + 1] + numMatrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startingRow = row;
                        startingCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = startingRow; row < startingRow + 3; row++)
            {
                for (int col = startingCol; col < startingCol + 3; col++)
                {
                    Console.Write(numMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
