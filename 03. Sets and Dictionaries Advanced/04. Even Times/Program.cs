using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInts = int.Parse(Console.ReadLine());

            Dictionary<int, int> intsCounter = new Dictionary<int, int>();

            for (int i = 0; i < countOfInts; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());

                if (!intsCounter.ContainsKey(inputNum))
                {
                    intsCounter.Add(inputNum, 0);
                }

                intsCounter[inputNum]++;
            }

            Console.WriteLine(intsCounter.Single(n => n.Value % 2 == 0).Key);
        }
    }
}
