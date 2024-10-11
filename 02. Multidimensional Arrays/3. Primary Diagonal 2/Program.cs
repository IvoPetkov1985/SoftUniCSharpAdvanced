using System;
using System.Linq;

namespace _3._Primary_Diagonal_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    squareMatrix[row, col] = currentArray[col];
                }
            }

            int sum = default;

            for (int i = 0; i < squareMatrix.GetLength(0); i++)
            {
                sum += squareMatrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
