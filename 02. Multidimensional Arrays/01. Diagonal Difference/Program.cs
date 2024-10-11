using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] inputArray = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    squareMatrix[row, col] = inputArray[col];
                }
            }

            int primaryDiagonalSum = default;
            int secondaryDiagonalSum = default;

            for (int i = 0; i < squareMatrix.GetLength(0); i++)
            {
                primaryDiagonalSum += squareMatrix[i, i];
                secondaryDiagonalSum += squareMatrix[i, squareMatrix.GetLength(1) - 1 - i];
            }

            int result = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(result);
        }
    }
}
