using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<string> stack = new Stack<string>(expression
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToArray());

            int result = int.Parse(stack.Pop());

            while (stack.Any())
            {
                string oper = stack.Pop();
                int nextNum = int.Parse(stack.Pop());

                if (oper == "+")
                {
                    result += nextNum;
                }
                else if (oper == "-")
                {
                    result -= nextNum;
                }
            }

            Console.WriteLine(result);
        }
    }
}
