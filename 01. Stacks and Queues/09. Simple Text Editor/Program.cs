using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            Stack<string> textModifications = new Stack<string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(tokens[0]);

                if (command == 1)
                {
                    textModifications.Push(text);
                    text += tokens[1];
                }
                else if (command == 2)
                {
                    textModifications.Push(text);
                    int countToErase = int.Parse(tokens[1]);
                    text = text.Remove(text.Length - countToErase);
                }
                else if (command == 3)
                {
                    int index = int.Parse(tokens[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (command == 4)
                {
                    text = textModifications.Pop();
                }
            }
        }
    }
}
