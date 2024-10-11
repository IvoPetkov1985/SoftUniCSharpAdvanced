using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] symbols = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();

                char[] array = line.ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    symbols[row, col] = array[col];
                }
            }

            char searched = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                for (int j = 0; j < symbols.GetLength(1); j++)
                {
                    if (symbols[i, j] == searched)
                    {
                        Console.WriteLine($"{(i, j)}");
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
                Console.WriteLine($"{searched} does not occur in the matrix");
            }
        }
    }
}
