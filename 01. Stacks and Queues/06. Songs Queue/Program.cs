using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(sequence);

            string commandLine = Console.ReadLine();

            while (songs.Any())
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string songToAdd = string.Join(" ", tokens.Skip(1));

                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
