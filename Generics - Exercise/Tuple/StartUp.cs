using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] addressInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] beerInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] numberInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstNameAddress = addressInput[0];
            string lastNameAddress = addressInput[1];
            string cityNameAddress = string.Join(" ", addressInput.Skip(2));
            string fullNameAddress = $"{firstNameAddress} {lastNameAddress}";

            TupleBox<string, string> address = new TupleBox<string, string>(fullNameAddress, cityNameAddress);

            string consumerName = beerInput[0];
            int liters = int.Parse(beerInput[1]);

            TupleBox<string, int> beerTuple = new TupleBox<string, int>(consumerName, liters);

            int firstNum = int.Parse(numberInput[0]);
            double secondNum = double.Parse(numberInput[1]);

            TupleBox<int, double> numberTuple = new TupleBox<int, double>(firstNum, secondNum);

            Console.WriteLine(address.ToString());
            Console.WriteLine(beerTuple.ToString());
            Console.WriteLine(numberTuple.ToString());
        }
    }
}
