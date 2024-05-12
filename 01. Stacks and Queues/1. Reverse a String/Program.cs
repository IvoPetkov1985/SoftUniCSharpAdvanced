using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputText = Console.ReadLine()
                .ToCharArray();

            Stack<char> stack = new Stack<char>(inputText);

            foreach (char letter in stack)
            {
                Console.Write(letter);
            }

            Console.WriteLine();
        }
    }
}
