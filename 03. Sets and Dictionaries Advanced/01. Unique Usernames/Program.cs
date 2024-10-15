using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }
    }
}
