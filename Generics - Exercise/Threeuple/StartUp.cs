using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAddressInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstName = nameAddressInput[0];
            string lastName = nameAddressInput[1];
            string fullName = $"{firstName} {lastName}";
            string neighbourhood = nameAddressInput[2];
            string city = string.Join(" ", nameAddressInput.Skip(3));

            ThreeupleBox<string, string, string> addressThreeuple = new ThreeupleBox<string, string, string>(fullName, neighbourhood, city);

            string[] drunkenInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string drunkardName = drunkenInput[0];
            int liters = int.Parse(drunkenInput[1]);
            bool isDrunk = drunkenInput[2] == "drunk";

            ThreeupleBox<string, int, bool> drunkThreeuple = new ThreeupleBox<string, int, bool>(drunkardName, liters, isDrunk);

            string[] bankInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string clientName = bankInput[0];
            double balance = double.Parse(bankInput[1]);
            string bankName = bankInput[2];

            ThreeupleBox<string, double, string> bankThreeuple = new ThreeupleBox<string, double, string>(clientName, balance, bankName);

            Console.WriteLine(addressThreeuple.ToString());
            Console.WriteLine(drunkThreeuple.ToString());
            Console.WriteLine(bankThreeuple.ToString());
        }
    }
}
