using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns_2
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
                int[] currentArr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    numMatrix[row, col] = currentArr[col];
                }
            }

            for (int j = 0; j < numMatrix.GetLength(1); j++)
            {
                int currentSum = default;

                for (int i = 0; i < numMatrix.GetLength(0); i++)
                {
                    currentSum += numMatrix[i, j];
                }

                Console.WriteLine(currentSum);
            }
        }
    }
}
