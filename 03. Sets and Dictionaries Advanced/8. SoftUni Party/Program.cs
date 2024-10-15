using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            int totalCount = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(totalCount);

            foreach (string guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (string guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
