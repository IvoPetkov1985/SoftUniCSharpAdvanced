using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tyres = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.7),
                new Tire(1, 2.7)
            };

            Engine engine = new Engine(90, 4200);

            Car car = new Car("VW", "Golf", 2005, 80, 4, engine, tyres);
        }
    }
}
