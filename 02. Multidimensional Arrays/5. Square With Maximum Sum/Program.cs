using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = details[0];
            int cols = details[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] numArray = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numArray[j];
                }
            }

            int maxSum = int.MinValue;
            int firstRowFirstNum = 0;
            int firstRowSecondNum = 0;
            int secondRowFirstNum = 0;
            int secondRowSecondNum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = 0;

                    currentSum += matrix[row, col];
                    currentSum += matrix[row, col + 1];
                    currentSum += matrix[row + 1, col];
                    currentSum += matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        firstRowFirstNum = matrix[row, col];
                        firstRowSecondNum = matrix[row, col + 1];
                        secondRowFirstNum = matrix[row + 1, col];
                        secondRowSecondNum = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine(firstRowFirstNum + " " + firstRowSecondNum);
            Console.WriteLine(secondRowFirstNum + " " + secondRowSecondNum);
            Console.WriteLine(maxSum);
        }
    }
}
