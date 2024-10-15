using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, SortedSet<string>> book = new Dictionary<string, SortedSet<string>>();

            while (inputLine != "Lumpawaroo")
            {
                if (inputLine.Contains("|"))
                {
                    string[] tokens = inputLine.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = tokens[0];
                    string user = tokens[1];

                    if (!book.Values.Any(x => x.Contains(user)))
                    {
                        if (!book.ContainsKey(forceSide))
                        {
                            book.Add(forceSide, new SortedSet<string>());
                        }

                        book[forceSide].Add(user);
                    }
                }
                else
                {
                    string[] tokens = inputLine.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string user = tokens[0];
                    string forceSide = tokens[1];

                    foreach (KeyValuePair<string, SortedSet<string>> kvp in book)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            kvp.Value.Remove(user);
                            break;
                        }
                    }

                    if (!book.ContainsKey(forceSide))
                    {
                        book.Add(forceSide, new SortedSet<string>());
                    }

                    book[forceSide].Add(user);

                    Console.WriteLine($"{user} joins the {forceSide} side!");
                }

                inputLine = Console.ReadLine();
            }

            book = book.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, SortedSet<string>> kvp in book)
            {
                if (kvp.Value.Any())
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    foreach (string user in kvp.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
