using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements_2
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

            int sum = default;

            for (int i = 0; i < numMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < numMatrix.GetLength(1); j++)
                {
                    sum += numMatrix[i, j];
                }
            }

            Console.WriteLine(numMatrix.GetLength(0));
            Console.WriteLine(numMatrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
