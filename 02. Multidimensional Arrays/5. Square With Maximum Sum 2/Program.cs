using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions.First();
            int cols = dimensions.Last();

            int[,] numMatrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    numMatrix[row, col] = currentArray[col];
                }
            }

            int startRow = 0;
            int startCol = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < numMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < numMatrix.GetLength(1) - 1; j++)
                {
                    int currentSum = 0;

                    currentSum += numMatrix[i, j];
                    currentSum += numMatrix[i, j + 1];
                    currentSum += numMatrix[i + 1, j];
                    currentSum += numMatrix[i + 1, j + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            for (int row = startRow; row <= startRow + 1; row++)
            {
                for (int col = startCol; col <= startCol + 1; col++)
                {
                    Console.Write(numMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
