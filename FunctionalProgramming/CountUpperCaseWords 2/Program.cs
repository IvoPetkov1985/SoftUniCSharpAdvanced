using System;
using System.Linq;

namespace CountUpperCaseWords_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<char, bool> isUpperCase = c => Char.IsUpper(c);

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => isUpperCase(w[0]))
                .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
