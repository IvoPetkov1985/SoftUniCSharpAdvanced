using System;
using System.Linq;

namespace CountUpperCaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isStartingWithUpper = str => str[0] == str.ToUpper()[0];

            string[] allWords = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => isStartingWithUpper(w))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, allWords));
        }
    }
}
