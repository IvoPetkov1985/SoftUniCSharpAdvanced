using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
