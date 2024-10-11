using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = details[0];
            int cols = details[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int sum = 0;

            foreach (int item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
