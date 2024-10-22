using System;
using System.Collections.Generic;
using System.Linq;

namespace AddVat
{
    internal class Program
    {
        delegate double VatAdder(double num);

        static void Main(string[] args)
        {
            Func<string, double> doubleParser = x => double.Parse(x);

            VatAdder addingVat = x => x * 1.2;

            List<double> doubles = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(doubleParser)
                .Select(x => addingVat(x))
                .ToList();

            doubles.ForEach(x => Console.WriteLine($"{x:F2}"));
        }
    }
}
