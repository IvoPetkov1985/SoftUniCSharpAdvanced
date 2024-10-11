using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            long[][] triangle = new long[rowsCount][];

            triangle[0] = new long[] { 1 };

            for (int row = 1; row < rowsCount; row++)
            {
                triangle[row] = new long[row + 1];

                for (int col = 0; col < triangle[row].Length; col++)
                {
                    if (triangle[row - 1].Length > col)
                    {
                        triangle[row][col] += triangle[row - 1][col];
                    }

                    if (col > 0)
                    {
                        triangle[row][col] += triangle[row - 1][col - 1];
                    }
                }
            }

            foreach (long[] currentArray in triangle)
            {
                Console.WriteLine(string.Join(" ", currentArray));
            }
        }
    }
}
