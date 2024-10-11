using System;
using System.Linq;

namespace _4._Symbol_in_Matrix_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] squareMatrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string inputLine = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    squareMatrix[row, col] = inputLine[col];
                }
            }

            char searchedSymbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (squareMatrix[row, col] == searchedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
            }
        }
    }
}
