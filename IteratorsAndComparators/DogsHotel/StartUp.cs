namespace DogsHotel
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Roshko", "White", 3, "Ivo", "Penka");
            Dog dog2 = new Dog("Zari", "Yellow", 13, "Vesela");
            Dog dog3 = new Dog("Valcho", "Brown", 10, "Steet dog");
            Dog dog4 = new Dog("Bari", "Black", 4, "Dimitrichko", "Petranka");
            Dog dog5 = new Dog("Kari", "Mixed", 7);
            Dog dog6 = new Dog("Romance", "Melange", 10, "Gogi", "Albena");

            HouseOfDogs house = new HouseOfDogs(dog1, dog2, dog3, dog4, dog5, dog6);

            foreach (Dog dog in house)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine(string.Join(", ", dog6.OwnerNames.OrderBy(x => x)));
        }
    }
}
