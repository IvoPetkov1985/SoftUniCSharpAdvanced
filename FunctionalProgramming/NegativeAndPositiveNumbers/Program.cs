using System;
using System.Collections.Generic;
using System.Linq;

namespace NegativeAndPositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isNegative = x => x < 0;
            Predicate<int> isPositive = x => x >= 0;

            int[] allNums = new[] { 1, 2, 3, 4, 5, -10, -21, 22, 11, -33 };
            int[] negatives = allNums.Where(x => isNegative(x)).ToArray();
            int[] positives = allNums.Where(x => isPositive(x)).ToArray();

            Action<string> printCollection = x => Console.WriteLine(x);

            printCollection(string.Join(", ", negatives));
            printCollection(string.Join(", ", positives));

            Func<double, bool> isDoubleNegative = x => x < 0;
            Func<double, bool> isDoublePositive = x => x >= 0;

            List<double> doubles = new List<double> { 15.2, -10.1, -13.45, 21, -78, -88.88 };
            List<double> negativeDoubles = doubles.FindAll(x => isDoubleNegative(x));
            List<double> positiveDoubles = doubles.FindAll(x => isDoublePositive(x));

            printCollection(string.Join(", ", negativeDoubles));
            printCollection(string.Join(", ", positiveDoubles));

            Predicate<int> isEven = x => x % 2 == 0;

            ICollection<int> ints = new int[] { 14, 1, 10, 22, -15, -45, -44, 114 };
            ints = ints.Where(x => isEven(x)).OrderBy(x => x).ToArray();
            printCollection(string.Join(", ", ints));
        }
    }
}
