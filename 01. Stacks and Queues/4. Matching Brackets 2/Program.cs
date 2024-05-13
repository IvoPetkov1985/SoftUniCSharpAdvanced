using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Matching_Brackets_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mathExpression = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < mathExpression.Length; i++)
            {
                if (mathExpression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (mathExpression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    int endIndex = i;

                    string substring = mathExpression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
