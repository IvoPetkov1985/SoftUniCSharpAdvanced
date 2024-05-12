using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Reverse_a_String_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputArr = input.ToCharArray();

            Stack<char> charsStack = new Stack<char>(inputArr);

            while (true)
            {
                if (charsStack.Count == 0)
                {
                    break;
                }

                Console.Write(charsStack.Pop());
            }

            Console.WriteLine();
        }
    }
}
