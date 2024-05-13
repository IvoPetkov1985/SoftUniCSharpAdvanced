using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> playlist = new Queue<string>(sequence);

            string commandLine = Console.ReadLine();

            while (playlist.Any())
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens.First();

                if (command == "Play")
                {
                    playlist.Dequeue();
                }
                else if (command == "Add")
                {
                    string songName = string.Join(" ", tokens.Skip(1));

                    if (!playlist.Contains(songName))
                    {
                        playlist.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
