using System;

namespace HigherOrderFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long Aggregate(int start, int end, Func<long, long, long> oper)
            {
                long result = start;

                for (long i = start + 1; i <= end; i++)
                {
                    result = oper(result, i);
                }

                return result;
            }

            Console.WriteLine(Aggregate(1, 10, (a, b) => a + b));
            Console.WriteLine(Aggregate(1, 10, (a, b) => a * b));
            Console.WriteLine(Aggregate(1, 20, (a, b) => a * b));
            Console.WriteLine(Aggregate(1, 10, (a, b) => long.Parse("" + a + b)));

            Random random = new Random();
            Console.WriteLine(AggrFunc(1, 10, (x, y) => x + y + random.Next(1, 100)));

            int AggrFunc(int start, int end, Func<int, int, int> func)
            {
                int result = start;

                for (int i = start + 1; i <= end; i++)
                {
                    result = func(result, i);
                }

                return result;
            }
        }
    }
}
