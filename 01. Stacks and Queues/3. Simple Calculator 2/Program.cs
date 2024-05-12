using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expressionToPush = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> expression = new Stack<string>(expressionToPush);

            int firstNum = int.Parse(expression.Pop());
            int result = firstNum;

            while (expression.Count > 0)
            {
                string sign = expression.Pop();

                if (sign == "+")
                {
                    int nextNum = int.Parse(expression.Pop());
                    result += nextNum;
                }
                else if (sign == "-")
                {
                    int nextNum = int.Parse(expression.Pop());
                    result -= nextNum;
                }
            }

            Console.WriteLine(result);
        }
    }
}
