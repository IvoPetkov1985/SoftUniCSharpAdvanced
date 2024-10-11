using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int current = matrix[row, row];
                sum += current;
            }

            Console.WriteLine(sum);
        }
    }
}
