using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parentheses = new Stack<char>();

            foreach (char symbol in input)
            {
                if (symbol == '(' || symbol == '[' || symbol == '{')
                {
                    parentheses.Push(symbol);
                }
                else if (symbol == ')')
                {
                    if (!parentheses.Any() || parentheses.Pop() != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (symbol == ']')
                {
                    if (!parentheses.Any() || parentheses.Pop() != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (symbol == '}')
                {
                    if (!parentheses.Any() || parentheses.Pop() != '{')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (parentheses.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
